namespace LazyPythonGUICreator
{
    /* Erklärung
    Beim Erstellen der GUI mit tkinter werden (für mich) die folgenden wichtigen Informationen benötigt:
    1. Welche Art von Control soll der GUI hinzugefügt werden ? (Button, Textbox, usw.)
    2. Wie soll das Control benannt werden?
    3. Welche Höhe und Breite hat das Control?
    4. Wo ist es positioniert? (Ich nutze das Grid, daher hier GridRow und GridColumn)
    5. Was ist das übergeordnete Control? (Dargestellt durch den String "Master")
    6. Gibt es ein Event? (z.B. Klicken auf einen Button)
    */
    class PythonGuiControl
    {
        private PythonGuiControlType Type { get; set; }
        private string Name { get; set; }
        private int Height { get; set; }
        private int Width { get; set; }
        private int GridRow { get; set; }
        private int GridColumn { get; set; }
        private string Master { get; set; } 
        private bool hasEvent { get; set; }
    }

    public enum PythonGuiControlType
    {
        Frame,
        Button,
        Text,
        Label
    }
}