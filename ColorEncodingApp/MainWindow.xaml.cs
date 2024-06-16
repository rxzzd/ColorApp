using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ColorEncodingApp.Models;
using ColorEncodingApp.Services;

namespace ColorEncodingApp
{
    public partial class MainWindow : Window
    {
        private ImageProcessor _imageProcessor;
        private string _currentImagePath;

        public MainWindow()
        {
            InitializeComponent();
            _imageProcessor = new ImageProcessor();
        }


        private void LoadImageButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpg)|*.png;*.jpg";

            if (openFileDialog.ShowDialog() == true)
            {
                _currentImagePath = openFileDialog.FileName;

                try
                {
                    LoadedImage.Source = new BitmapImage(new Uri(_currentImagePath));

                    List<ColorInfo> colorInfos = _imageProcessor.GetColorInfo(_currentImagePath);
                    ColorListBox.ItemsSource = colorInfos.OrderByDescending(c => c.Count).Take(10).ToList();

                    ImageBorder.BorderBrush = new SolidColorBrush(Colors.Transparent);
                }
                catch (NotSupportedException ex)
                {
                    MessageBox.Show("The selected file is not a supported image format.", "Unsupported Image", MessageBoxButton.OK, MessageBoxImage.Error);
                    Console.WriteLine(ex.Message); 
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show("The selected file is not a valid image.", "Invalid Image", MessageBoxButton.OK, MessageBoxImage.Error);
                    Console.WriteLine(ex.Message); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading the image.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    Console.WriteLine(ex.Message); 
                }
            }
        }

        private void LoadedImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (_currentImagePath == null)
                return;

            var pos = e.GetPosition(LoadedImage);
            var bitmap = new BitmapImage(new Uri(_currentImagePath));
            var scale = bitmap.PixelHeight / LoadedImage.ActualHeight;
            int x = (int)(pos.X * scale);
            int y = (int)(pos.Y * scale);

            ColorInfo colorInfo = _imageProcessor.GetPixelColor(_currentImagePath, x, y);

            SelectedColorRectangle.Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colorInfo.HtmlCode));
            SelectedColorCode.Text = $"HTML: {colorInfo.HtmlCode}";
            SelectedColorRGB.Text = $"RGB: {colorInfo.Red}, {colorInfo.Green}, {colorInfo.Blue}";

            SelectedColorBorder.Visibility = Visibility.Visible;
        }
    }
}

