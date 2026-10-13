using System;
using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace OperationsHub;

// MainWindow is a class. Put fields and methods inside these outer braces.
public partial class MainWindow : Window
{
    private readonly System.Collections.ObjectModel.ObservableCollection<string> items = new();
    public MainWindow()
    {
        InitializeComponent();
        lstItems.ItemsSource = items;
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
        // TODO (Timer chapter): Implement Timer in the matching tutorial chapter.
        // Replace this placeholder with the handler shown in that chapter.
        txtStatus.Text = "Timer_Click: behavior still to build.";
    }

    private void Reset_Click(object sender, RoutedEventArgs e)
    {
        // TODO (Timer chapter): Implement Reset in the matching tutorial chapter.
        // Replace this placeholder with the handler shown in that chapter.
        txtStatus.Text = "Reset_Click: behavior still to build.";
    }

    private void Save_Click(object sender, RoutedEventArgs e)
    {
        // TODO (Text files chapter): Implement Save in the matching tutorial chapter.
        // Replace this placeholder with the handler shown in that chapter.
        txtStatus.Text = "Save_Click: behavior still to build.";
    }

    private void Open_Click(object sender, RoutedEventArgs e)
    {
        // TODO (Text files chapter): Implement Open in the matching tutorial chapter.
        // Replace this placeholder with the handler shown in that chapter.
        txtStatus.Text = "Open_Click: behavior still to build.";
    }

    private void Image_Click(object sender, RoutedEventArgs e)
    {
        // TODO (Artwork chapter): Implement Image in the matching tutorial chapter.
        // Replace this placeholder with the handler shown in that chapter.
        txtStatus.Text = "Image_Click: behavior still to build.";
    }
}
