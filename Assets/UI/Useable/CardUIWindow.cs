using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class CardUIWindow : EditorWindow
{
    [SerializeField]
    private VisualTreeAsset m_VisualTreeAsset = default;

    [MenuItem("Window/UI Toolkit/CardUIWindow")]
    public static void ShowExample()
    {
        CardUIWindow wnd = GetWindow<CardUIWindow>();
        wnd.titleContent = new GUIContent("CardUIWindow");
    }

    public void CreateGUI()
    {
        // Each editor window contains a root VisualElement object
        VisualElement root = rootVisualElement;

        // VisualElements objects can contain other VisualElement following a tree hierarchy.
        VisualElement label = new Label("Hello World! From C#");
        root.Add(label);

        // Instantiate UXML
        VisualElement labelFromUXML = m_VisualTreeAsset.Instantiate();
        root.Add(labelFromUXML);
    }
}
