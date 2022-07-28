using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using System.Collections.Generic;

public enum VariableTypes
{
    Float,
    Int,
    String,
    Bool
}
struct ValueStruct
{
    public string varName;
    public string type;

    public ValueStruct(string varName, string type)
    {
        this.varName = varName;
        this.type = type;
    }
}

public class CardVariableManager : EditorWindow
{


    List<ValueStruct> ValueStructs = new List<ValueStruct>();

    TextField VariableNameTextField;
    EnumField VariableTypeEnumField;
    ScrollView VariableView;

    public string GetVariableTypeText(VariableTypes variableTypes)
    {
        switch (variableTypes)
        {
            case VariableTypes.Float:
                return "float";
            case VariableTypes.Int:
                return "int";
            case VariableTypes.String:
                return "string";
            case VariableTypes.Bool:
                return "bool";
        }

        return "Unknown Type";
    }

    public VariableTypes GetVariableTypesEnumFromString(string variableTypes)
    {
        switch (variableTypes)
        {
            case "float":
                return VariableTypes.Float;
            case "int":
                return VariableTypes.Int;
            case "string":
                return VariableTypes.String;
            case "bool":
                return VariableTypes.Bool;
        }

        return VariableTypes.Bool;
    }

    public void AddVariableButtonPushed()
    {
        AddVariableTypeToUI(VariableNameTextField.value, GetVariableTypeText((VariableTypes)VariableTypeEnumField.value));
    }

    [SerializeField]
    private VisualTreeAsset m_VisualTreeAsset = default;
    [SerializeField]
    private VisualTreeAsset m_VariableDisplayingTemplate;

    [MenuItem("Tools/Card Builder Toolkit/Card Variable Manager")]
    public static void ShowExample()
    {
        CardVariableManager wnd = GetWindow<CardVariableManager>();
        wnd.titleContent = new GUIContent("Card Variable Manager");
    }
    public void AddVariableTypeToUI(string name, string variableText)
    {
        if (DoesVariableAlreadyExist(name))
        {
            // TODO in the future add some red text somewhere
            return;
        }

        ValueStruct a = new ValueStruct(name, variableText);
        ValueStructs.Add(a);
        ReRenderVariableUI();
    }


    public bool DoesVariableAlreadyExist(string name)
    {

        for (int i = 0; i < ValueStructs.Count; i++)
        {
            if (ValueStructs[i].varName == name) return true;
        }
        return false;
    }


    public void RemoveAllVariableUI()
    {
        VisualElement root = rootVisualElement;

        VariableView = root.Q<ScrollView>(name: "VariableView");
        VariableView.Clear();
    }

    public void AddAllVariableUI()
    {
        VisualElement root = rootVisualElement;
        VariableView = root.Q<ScrollView>(name: "VariableView");
        for (int i = 0; i < ValueStructs.Count; i++)
        {
            VisualElement labelFromUXML = m_VariableDisplayingTemplate.Instantiate();
            labelFromUXML.Q<Label>(name: "VariableNameText").text = ValueStructs[i].varName;
            labelFromUXML.Q<Label>(name: "VariableTypeText").text = ValueStructs[i].type;
            VariableView.Add(labelFromUXML);
        }
        
    }

    public void ReRenderVariableUI()
    {
        RemoveAllVariableUI();
        AddAllVariableUI();
    }

    public void CreateGUI()
    {
        // Each editor window contains a root VisualElement object
        VisualElement root = rootVisualElement;

        // Instantiate UXML
        VisualElement labelFromUXML = m_VisualTreeAsset.Instantiate();
        root.Add(labelFromUXML);

        VariableNameTextField = root.Q<TextField>(name: "VariableNameTextField");
        VariableTypeEnumField = root.Q<EnumField>(name: "VariableTypeEnumField");
        VariableView = root.Q<ScrollView>(name: "VariableView");

        root.Q<Button>(name: "AddVariableButton").clicked += () =>
        {
            AddVariableButtonPushed();
        };

        
    }
}
