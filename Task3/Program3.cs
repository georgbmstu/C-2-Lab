class DocumentWorker
{
    public void OpenDocument()
    {
        Console.WriteLine("Документ открыт");
    }
    public virtual void EditDocument()
    {
        Console.WriteLine("Редактирование документа доступно в версии Pro");
    }
    public virtual void SaveDocument()
    {
        Console.WriteLine("Сохранение документа доступно в версии  Pro");
    }
}
class ProDocumentWorker: DocumentWorker
{
    public override void EditDocument()
    {
        Console.WriteLine("Документ отредактирован");
    }
    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранён в старом формате, сохранение в остальных форматах доступно в версии Expert");
    }
}
class ExpertDocumnetWorker: ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранён в новом формате");
    }
}
class Program
{
    static void Main()
    {
        DocumentWorker doc;
        string access_key;
        Console.Write("Введите ключ: ");
        access_key = Console.ReadLine();
        if (access_key == "pro")
        {
            doc = new ProDocumentWorker();
        }
        else if (access_key == "exp")
        {
            doc = new ExpertDocumnetWorker();
        }
        else
        {
            doc = new DocumentWorker();
        }
        doc.OpenDocument();
        doc.EditDocument();
        doc.SaveDocument();
    }
}