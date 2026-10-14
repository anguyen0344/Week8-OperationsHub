using System;
using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace OperationsHub;

// MainWindow is a class. Put fields and methods inside these outer braces.
public partial class MainWindow : Window
{
    private readonly System.Collections.ObjectModel.ObservableCollection<string> items = new();
    private readonly System.Windows.Threading.DispatcherTimer timer = new();
    private int remainingSeconds = 25 * 60;
    public MainWindow()
    {
        InitializeComponent();
        lstItems.ItemsSource = items;

        timer.Interval = TimeSpan.FromSeconds(1);
        timer.Tick += Timer_Tick;
        Closed += (_, _) => timer.Stop();

        UpdateTimer();
    }
    private void Timer_Tick(object? sender, EventArgs e)
    {
        remainingSeconds--;
        UpdateTimer();

        if (remainingSeconds <= 0)
        {
            timer.Stop();
            txtStatus.Text = "Focus interval complete.";
        }
    }

    private void UpdateTimer()
    {
        txtTimer.Text = TimeSpan.FromSeconds(remainingSeconds)
            .ToString(@"mm\:ss");
    }
    private void AddItem()
    {
        string entry = txtEntry.Text.Trim();

        if (string.IsNullOrWhiteSpace(entry))
        {
            txtStatus.Text = "Enter a study task first.";
            return;
        }

        items.Add(entry);
        txtEntry.Clear();
        txtStatus.Text = "Task added.";
    }

    private void Add_Click(object sender, RoutedEventArgs e)
    {
        AddItem();
    }

    private void Remove_Click(object sender, RoutedEventArgs e)
    {
        if (lstItems.SelectedItem is not string entry)
        {
            txtStatus.Text = "Select a task to remove.";
            return;
        }

        items.Remove(entry);
        txtStatus.Text = "Task removed.";
    }

    private void Timer_Click(object sender, RoutedEventArgs e)
    {
        if (timer.IsEnabled)
        {
            timer.Stop();
            txtStatus.Text = "Focus timer paused.";
        }
        else if (remainingSeconds > 0)
        {
            timer.Start();
            txtStatus.Text = "Focus timer running.";
        }
        else
        {
            txtStatus.Text = "Reset the completed timer first.";
        }
    }

    private void Reset_Click(object sender, RoutedEventArgs e)
    {
        timer.Stop();
        remainingSeconds = 25 * 60;
        UpdateTimer();
        txtStatus.Text = "Timer reset to 25 minutes.";
    }
    private string BuildReport()
    {
        string report = "CS110 Study Task Hub\n\n";
        report += "Study notes:\n" + txtDocument.Text + "\n\n";
        report += "Study tasks:\n";

        foreach (string item in items)
        {
            report += "- " + item + "\n";
        }

        return report;
    }
    private void SaveText(string text)
    {
        var dialog = new Microsoft.Win32.SaveFileDialog
        {
            Filter = "Text files|*.txt",
            FileName = "study-report.txt"
        };

        if (dialog.ShowDialog() != true)
        {
            txtStatus.Text = "Save canceled. Your text stays here.";
            return;
        }

        try
        {
            System.IO.File.WriteAllText(dialog.FileName, text);
            txtStatus.Text = "Saved: "
                + System.IO.Path.GetFileName(dialog.FileName);
        }
        catch (Exception ex)
        {
            txtStatus.Text = "Could not save. Choose a writable folder: "
                + ex.Message;
        }
    }
    private void Save_Click(object sender, RoutedEventArgs e)
    {
        SaveText(BuildReport());
    }

    private void Open_Click(object sender, RoutedEventArgs e)
    {
        var dialog = new Microsoft.Win32.OpenFileDialog
        {
            Filter = "Text files|*.txt"
        };

        if (dialog.ShowDialog() != true)
        {
            txtStatus.Text = "Open canceled. Your current text stays here.";
            return;
        }

        try
        {
            txtDocument.Text =
                System.IO.File.ReadAllText(dialog.FileName);

            txtStatus.Text = "Text reopened. Review it before editing.";
        }
        catch (Exception ex)
        {
            txtStatus.Text = "Could not read the file: " + ex.Message;
        }
    }
    private void Image_Click(object sender, RoutedEventArgs e)
    {
        var dialog = new Microsoft.Win32.OpenFileDialog
        {
            Filter = "Image files|*.png;*.jpg;*.jpeg"
        };

        if (dialog.ShowDialog() != true)
        {
            txtStatus.Text = "Image selection canceled.";
            return;
        }

        try
        {
            var image = new System.Windows.Media.Imaging.BitmapImage();
            image.BeginInit();
            image.CacheOption =
                System.Windows.Media.Imaging.BitmapCacheOption.OnLoad;
            image.UriSource = new Uri(dialog.FileName, UriKind.Absolute);
            image.EndInit();

            imgArtwork.Source = image;
            imgButton.Source = image;
            txtStatus.Text = "Artwork loaded.";
        }
        catch (Exception ex)
        {
            txtStatus.Text = "Could not load the image: " + ex.Message;
        }
    }
}
