namespace InteractiveReadingTool;

public partial class LessonWorkArea: ContentPage{

    public LessonWorkArea()
	{
		InitializeComponent();
	}

	private void OnMenuButtonClicked(object sender, EventArgs e)
        {
            // Toggle the visibility of the flyout menu
            FlyoutMenu.IsVisible = !FlyoutMenu.IsVisible;
        }

        private void OnBackClicked(object sender, EventArgs e)
        {
            FlyoutMenu.IsVisible = false; // Hide the flyout menu
        }
}
