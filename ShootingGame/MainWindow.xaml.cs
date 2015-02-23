using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace ShootingGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer Timer = new DispatcherTimer(DispatcherPriority.Send);
        Random CoordinateSelector = new Random();
        int Score = 0, MaxRows = 9, MaxColumns = 10;
                
        public MainWindow()
        {
            InitializeComponent();

            GameInitializer(false);

            Grid.SetRow(Target, CoordinateSelector.Next(1, MaxRows));
            Grid.SetColumn(Target, CoordinateSelector.Next(0, MaxColumns));

            Timer.Interval = TimeSpan.FromMilliseconds(999);
            Timer.Tick += Timer_Tick;
        }

        void GameInitializer(bool ForPause)
        {
            if(!ForPause)
            {
                Score = 0;
                ScoreBoard.Content = "Score : " + Score;
            }

            Target.Fill = Brushes.Chocolate;
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            Target.Fill = Brushes.Chocolate;

            Grid.SetRow(Target, CoordinateSelector.Next(1, MaxRows));
            Grid.SetColumn(Target, CoordinateSelector.Next(0, MaxColumns));
        }

        private void Target_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Target.Fill == Brushes.Chocolate)
            {
                if(Sound.IsEnabled == true)
                {
                    Sound.Stop();
                }
                Sound.Play();
                Target.Fill = Brushes.Red;

                ScoreBoard.Content = "Score : " + ++Score;

                if (Timer.Interval.Milliseconds > 250)
                {
                    Timer.Interval = TimeSpan.FromMilliseconds(Timer.Interval.Milliseconds - 10);
                }
            }
        }

        private void ImageButtons_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            switch((sender as Image).Name.ToString())
            {
                case "Quit":
                    this.Close();
                    break;
                case "ToggleMaximize":
                    if (this.WindowState == System.Windows.WindowState.Normal)
                    {
                        this.WindowState = System.Windows.WindowState.Maximized;
                    }
                    else
                    {
                        this.WindowState = System.Windows.WindowState.Normal;
                    }
                    break;
                case "PausePlay":
                    if (Timer.IsEnabled == false)
                    {
                        Timer.Start();
                        Target.Opacity = 1;
                    }
                    else
                    {
                        Timer.Stop();
                        GameInitializer(true);
                    }
                    break;
                case "EndGame":
                    Timer.Stop();
                    Target.Opacity = 0;
                    MessageBox.Show("Score : " + Score, "Game Over!!");
                    GameInitializer(false);
                    break;
            }
        }
    }
}

//using System;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Shapes;
//using System.Windows.Threading;

//namespace ShootingGame
//{
//    /// <summary>
//    /// Interaction logic for MainWindow.xaml
//    /// </summary>
//    public partial class MainWindow : Window
//    {
//        DispatcherTimer Timer = new DispatcherTimer(DispatcherPriority.Send);
//        Random CoordinateSelector = new Random();
//        int Score = 0, MaxRows = 9, MaxColumns = 10;
//        int incrementor = -1;


//        public MainWindow()
//        {
//            InitializeComponent();

//            GameInitializer(false);

//            Timer.Interval = TimeSpan.FromMilliseconds(9);
//            Timer.Tick += Timer_Tick;
//        }

//        void GameInitializer(bool ForPause)
//        {
//            if(!ForPause)
//            {
//                Score = 0;
//                ScoreBoard.Content = "Score : " + Score;
//            }


//            for (int i = 0; i < 7; i++)
//            {
//                var Target = FindName("Target" + i) as Ellipse;
//                var margin = Target.Margin;
//                margin.Top = 500;
//                margin.Left = CoordinateSelector.Next(1, 300);
//                Target.Margin = margin;
//                Target.Visibility = Visibility.Visible;
//                Grid.SetRow(Target, 1);
//                Grid.SetColumn(Target, 0);
//            }
//        }

//        void Timer_Tick(object sender, EventArgs e)
//        {
//            for (int i = 0; i < 7; i++)
//            {
//                var Target = FindName("Target" + i) as System.Windows.Shapes.Ellipse;

//                Target.Fill = Brushes.Chocolate;

//                var margin = Target.Margin;
//                if (Target.Margin.Top < 300)
//                {
//                    incrementor = 1;
//                }
//                else if (Target.Margin.Top > 500)
//                {
//                    incrementor = -1;
//                    margin.Left = 0;
//                }
//                margin.Left += 0.3;
//                margin.Top += incrementor;
//                Target.Margin = margin;
//                //Grid.SetRow(Target, CoordinateSelector.Next(1, MaxRows));
//                //Grid.SetColumn(Target, CoordinateSelector.Next(0, MaxColumns));
//            }
//        }

//        private void Target_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
//        {
//            var Target = sender as System.Windows.Shapes.Ellipse;
//            if (Target.Fill == Brushes.Chocolate)
//            {
//                var margin = Target.Margin;
//                margin.Top = 500;
//                margin.Left = CoordinateSelector.Next(1, 300);
//                Target.Margin = margin;

//                if(Sound.IsEnabled == true)
//                {
//                    Sound.Stop();
//                }
//                Sound.Play();
//                Target.Fill = Brushes.Red;

//                ScoreBoard.Content = "Score : " + ++Score;

//                if (Timer.Interval.Milliseconds > 250)
//                {
//                    Timer.Interval = TimeSpan.FromMilliseconds(Timer.Interval.Milliseconds - 10);
//                }
//            }
//        }

//        private void ImageButtons_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
//        {
//            switch ((sender as Image).Name.ToString())
//            {
//                case "Quit":
//                    this.Close();
//                    break;
//                case "ToggleMaximize":
//                    if (this.WindowState == System.Windows.WindowState.Normal)
//                    {
//                        this.WindowState = System.Windows.WindowState.Maximized;
//                    }
//                    else
//                    {
//                        this.WindowState = System.Windows.WindowState.Normal;
//                    }
//                    break;
//                case "PausePlay":
//                    if (Timer.IsEnabled == false)
//                    {
//                        Timer.Start();


//                        for (int i = 0; i < 7; i++)
//                        {
//                            var Target = FindName("Target" + i) as Ellipse;
//                            Target.Visibility = Visibility.Visible;
//                        }
//                    }
//                    else
//                    {
//                        Timer.Stop();
//                        GameInitializer(true);
//                    }
//                    break;
//                case "EndGame":
//                    Timer.Stop();

//                    for (int i = 0; i < 7; i++)
//                    {
//                        var Target = FindName("Target" + i) as Ellipse;
//                        Target.Visibility = Visibility.Visible;
//                    }
//                    MessageBox.Show("Score : " + Score, "Game Over!!");
//                    GameInitializer(false);
//                    break;
//            }
//        }
//    }
//}