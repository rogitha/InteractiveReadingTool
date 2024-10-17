using System.Collections.ObjectModel;
namespace InteractiveReadingTool;

public partial class StudentDirectory : ContentPage
{
    public StudentDirectory()
    {
        InitializeComponent();

        PopulateCollectionView();
    }

    private void PopulateCollectionView ()
    {
        var studentNames = new ObservableCollection<string>();
        studentNames.Add("Pandeli Deforest");
        studentNames.Add("Naveen Lin");
        studentNames.Add("Efigénia Accardi");
        studentNames.Add("Jerred Ortega");
        studentNames.Add("Edvinas Furnadxhieva");
        studentNames.Add("Silvius Tosto");
        studentNames.Add("Ingolf Agema");
        studentNames.Add("Origenes Mohammed");

        var lessons = new ObservableCollection<string>();
        lessons.Add("Lesson 1.1");
        lessons.Add("Lesson 1.2");
        lessons.Add("Lesson 1.3");
        lessons.Add("Lesson 1.4");
        lessons.Add("Lesson 1.5");
        lessons.Add("Lesson 1.6");
        lessons.Add("Lesson 1.7");
        lessons.Add("Lesson 2.1");
        lessons.Add("Lesson 2.2");
        lessons.Add("Lesson 2.3");
        lessons.Add("Lesson 2.4");
        lessons.Add("Lesson 2.5");
        lessons.Add("Lesson 2.6");
        lessons.Add("Lesson 2.7");

        FakeStudentData.ItemsSource = studentNames;
        LessonsList.ItemsSource = lessons;
    }
}