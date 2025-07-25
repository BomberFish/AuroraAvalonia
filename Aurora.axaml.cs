using Avalonia.Animation;
using Avalonia.Animation.Easings;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.VisualTree;
using Avalonia.Controls.Shapes;
using Avalonia.Styling;
using Avalonia.Threading;
using System;
using System.Linq;

namespace AuroraAvalonia;

public partial class Aurora : UserControl
{
    public Aurora()
    {
        InitializeComponent();

        new Animation() {
            Duration = TimeSpan.FromSeconds(5),
            IterationCount = IterationCount.Infinite,
            PlaybackDirection = PlaybackDirection.Alternate,
            Children = {
                new KeyFrame {
                    Cue = default,
                    Setters = {
                        new Setter(Path.OpacityProperty, 0),
                    }
                },
                new KeyFrame {
                    Cue = new Cue(1),
                    Setters = {
                        new Setter(Path.OpacityProperty, 1),
                    },
                },
            }
        }.RunAsync(this.FindControl<Path>("Background2Colors"));

        new Animation() {
            Duration = TimeSpan.FromSeconds(6),
            IterationCount = IterationCount.Infinite,
            PlaybackDirection = PlaybackDirection.Alternate,
            Children = {
                new KeyFrame {
                    Cue = default,
                    Setters = {
                        new Setter(Path.OpacityProperty, 0),
                    }
                },
                new KeyFrame {
                    Cue = new Cue(1),
                    Setters = {
                        new Setter(Path.OpacityProperty, 1),
                    },
                },
            }
        }.RunAsync(this.FindControl<Path>("Background3Colors"));

        new Animation() {
            Duration = TimeSpan.FromSeconds(4),
            IterationCount = IterationCount.Infinite,
            PlaybackDirection = PlaybackDirection.Alternate,
            Children = {
                new KeyFrame {
                    Cue = default,
                    Setters = {
                        new Setter(Canvas.OpacityProperty, 1.0),
                    }
                },
                new KeyFrame {
                    Cue = new Cue(1),
                    Setters = {
                        new Setter(Canvas.OpacityProperty, 0.1),
                    },
                },
            }
        }.RunAsync(this.FindControl<Canvas>("Group5"));

        new Animation() {
            Duration = TimeSpan.FromSeconds(4),
            IterationCount = IterationCount.Infinite,
            PlaybackDirection = PlaybackDirection.Alternate,
            Children = {
                new KeyFrame {
                    Cue = default,
                    Setters = {
                        new Setter(Canvas.OpacityProperty, 1.0),
                    }
                },
                new KeyFrame {
                    Cue = new Cue(1),
                    Setters = {
                        new Setter(Canvas.OpacityProperty, 0.1),
                    },
                },
            }
        }.RunAsync(this.FindControl<Canvas>("Group4"));

        new Animation() {
            Duration = TimeSpan.FromSeconds(2),
            IterationCount = IterationCount.Infinite,
            PlaybackDirection = PlaybackDirection.Alternate,
            Children = {
                new KeyFrame {
                    Cue = default,
                    Setters = {
                        new Setter(Path.OpacityProperty, 0),
                    }
                },
                new KeyFrame {
                    Cue = new Cue(1),
                    Setters = {
                        new Setter(Path.OpacityProperty, 1),
                    },
                },
            }
        }.RunAsync(this.FindControl<Path>("Path1"));

        var movingRays = this.FindControl<Canvas>("MovingRays");
        if (movingRays != null)
        {
            var timer1 = new DispatcherTimer();
            timer1.Interval = TimeSpan.FromMilliseconds(50);
            var startTime1 = DateTime.Now;

            timer1.Tick += (sender, e) =>
            {
                var elapsed = (DateTime.Now - startTime1).TotalSeconds;
                var cyclePosition = (elapsed % 20.0) / 20.0;
                var x = 100.0 + (Math.Sin(cyclePosition * 2 * Math.PI) * 100.0);
                // var x = progress * 200.0; // original, incorrect behaviour
                movingRays.RenderTransform = new TranslateTransform(x, 0);
            };
            timer1.Start();
        }

        var lights = this.FindControl<Canvas>("Lights");
        if (lights != null)
        {
            var timer2 = new DispatcherTimer();
            timer2.Interval = TimeSpan.FromMilliseconds(33);
            var startTime2 = DateTime.Now;

            timer2.Tick += (sender, e) =>
            {
                var elapsed = (DateTime.Now - startTime2).TotalSeconds;
                var cyclePosition = (elapsed % 6.0) / 6.0;
                var x = Math.Sin(cyclePosition * 2 * Math.PI) * 10.0;
                // var x = -10.0 + (progress * 20.0); // original, incorrect behaviour
                lights.RenderTransform = new TranslateTransform(x, 0);
            };
            timer2.Start();
        }

        // Group3 opacity animation (1 to 0, 0:0:3)
        new Animation() {
            Duration = TimeSpan.FromSeconds(3),
            IterationCount = IterationCount.Infinite,
            PlaybackDirection = PlaybackDirection.Alternate,
            Children = {
                new KeyFrame {
                    Cue = default,
                    Setters = {
                        new Setter(Canvas.OpacityProperty, 1.0),
                    }
                },
                new KeyFrame {
                    Cue = new Cue(1),
                    Setters = {
                        new Setter(Canvas.OpacityProperty, 0.0),
                    },
                },
            }
        }.RunAsync(this.FindControl<Canvas>("Group3"));

        new Animation() {
            Duration = TimeSpan.FromSeconds(2),
            IterationCount = IterationCount.Infinite,
            PlaybackDirection = PlaybackDirection.Alternate,
            Children = {
                new KeyFrame {
                    Cue = default,
                    Setters = {
                        new Setter(Canvas.OpacityProperty, 0.6),
                    }
                },
                new KeyFrame {
                    Cue = new Cue(1),
                    Setters = {
                        new Setter(Canvas.OpacityProperty, 0.2),
                    },
                },
            }
        }.RunAsync(this.FindControl<Canvas>("Group1"));

        new Animation() {
            Duration = TimeSpan.FromSeconds(3),
            IterationCount = IterationCount.Infinite,
            PlaybackDirection = PlaybackDirection.Alternate,
            Children = {
                new KeyFrame {
                    Cue = default,
                    Setters = {
                        new Setter(Path.OpacityProperty, 0),
                    }
                },
                new KeyFrame {
                    Cue = new Cue(1),
                    Setters = {
                        new Setter(Path.OpacityProperty, 1),
                    },
                },
            }
        }.RunAsync(this.FindControl<Path>("Path6_Copy3"));

        new Animation() {
            Duration = TimeSpan.FromSeconds(3),
            IterationCount = IterationCount.Infinite,
            PlaybackDirection = PlaybackDirection.Alternate,
            Children = {
                new KeyFrame {
                    Cue = default,
                    Setters = {
                        new Setter(Canvas.OpacityProperty, 0),
                    }
                },
                new KeyFrame {
                    Cue = new Cue(1),
                    Setters = {
                        new Setter(Canvas.OpacityProperty, 1),
                    },
                },
            }
        }.RunAsync(this.FindControl<Canvas>("Group2"));

        new Animation() {
            Duration = TimeSpan.FromSeconds(2),
            IterationCount = IterationCount.Infinite,
            PlaybackDirection = PlaybackDirection.Alternate,
            Children = {
                new KeyFrame {
                    Cue = default,
                    Setters = {
                        new Setter(Path.OpacityProperty, 0),
                    }
                },
                new KeyFrame {
                    Cue = new Cue(1),
                    Setters = {
                        new Setter(Path.OpacityProperty, 1),
                    },
                },
            }
        }.RunAsync(this.FindControl<Path>("Path6_Copy1"));

        new Animation() {
            Duration = TimeSpan.FromSeconds(10),
            IterationCount = IterationCount.Infinite,
            PlaybackDirection = PlaybackDirection.Alternate,
            Children = {
                new KeyFrame {
                    Cue = default,
                    Setters = {
                        new Setter(Canvas.OpacityProperty, 0),
                    }
                },
                new KeyFrame {
                    Cue = new Cue(1),
                    Setters = {
                        new Setter(Canvas.OpacityProperty, 1),
                    },
                },
            }
        }.RunAsync(this.FindControl<Canvas>("MovingRays"));

        new Animation() {
            Duration = TimeSpan.FromSeconds(5),
            IterationCount = IterationCount.Infinite,
            PlaybackDirection = PlaybackDirection.Alternate,
            Children = {
                new KeyFrame {
                    Cue = default,
                    Setters = {
                        new Setter(Path.OpacityProperty, 0),
                    }
                },
                new KeyFrame {
                    Cue = new Cue(1),
                    Setters = {
                        new Setter(Path.OpacityProperty, 1),
                    },
                },
            }
        }.RunAsync(this.FindControl<Path>("Rectangle3ColorVariation"));

        new Animation() {
            Duration = TimeSpan.FromSeconds(4),
            IterationCount = IterationCount.Infinite,
            PlaybackDirection = PlaybackDirection.Alternate,
            Children = {
                new KeyFrame {
                    Cue = default,
                    Setters = {
                        new Setter(Path.OpacityProperty, 0),
                    }
                },
                new KeyFrame {
                    Cue = new Cue(1),
                    Setters = {
                        new Setter(Path.OpacityProperty, 1),
                    },
                },
            }
        }.RunAsync(this.FindControl<Path>("Rectangle1ColorVariation"));

        new Animation() {
            Duration = TimeSpan.FromSeconds(6),
            IterationCount = IterationCount.Infinite,
            PlaybackDirection = PlaybackDirection.Alternate,
            Children = {
                new KeyFrame {
                    Cue = default,
                    Setters = {
                        new Setter(Canvas.OpacityProperty, 0.7),
                    }
                },
                new KeyFrame {
                    Cue = new Cue(1),
                    Setters = {
                        new Setter(Canvas.OpacityProperty, 0.1),
                    },
                },
            }
        }.RunAsync(this.FindControl<Canvas>("BottomLights"));

        new Animation() {
            Duration = TimeSpan.FromSeconds(2),
            IterationCount = IterationCount.Infinite,
            PlaybackDirection = PlaybackDirection.Alternate,
            Children = {
                new KeyFrame {
                    Cue = default,
                    Setters = {
                        new Setter(Path.OpacityProperty, 0),
                    }
                },
                new KeyFrame {
                    Cue = new Cue(1),
                    Setters = {
                        new Setter(Path.OpacityProperty, 0.5),
                    },
                },
            }
        }.RunAsync(this.FindControl<Path>("Path8_Copy1"));

        new Animation() {
            Duration = TimeSpan.FromSeconds(2),
            IterationCount = IterationCount.Infinite,
            PlaybackDirection = PlaybackDirection.Alternate,
            Children = {
                new KeyFrame {
                    Cue = default,
                    Setters = {
                        new Setter(Path.OpacityProperty, 0),
                    }
                },
                new KeyFrame {
                    Cue = new Cue(1),
                    Setters = {
                        new Setter(Path.OpacityProperty, 1),
                    },
                },
            }
        }.RunAsync(this.FindControl<Path>("Path8_Copy10"));

        new Animation() {
            Duration = TimeSpan.FromSeconds(3),
            IterationCount = IterationCount.Infinite,
            PlaybackDirection = PlaybackDirection.Alternate,
            Children = {
                new KeyFrame {
                    Cue = default,
                    Setters = {
                        new Setter(Canvas.OpacityProperty, 0),
                    }
                },
                new KeyFrame {
                    Cue = new Cue(1),
                    Setters = {
                        new Setter(Canvas.OpacityProperty, 1),
                    },
                },
            }
        }.RunAsync(this.FindControl<Canvas>("Lights"));

        new Animation() {
            Duration = TimeSpan.FromSeconds(2),
            IterationCount = IterationCount.Infinite,
            PlaybackDirection = PlaybackDirection.Alternate,
            Children = {
                new KeyFrame {
                    Cue = default,
                    Setters = {
                        new Setter(Canvas.OpacityProperty, 0),
                    }
                },
                new KeyFrame {
                    Cue = new Cue(1),
                    Setters = {
                        new Setter(Canvas.OpacityProperty, 1),
                    },
                },
            }
        }.RunAsync(this.FindControl<Canvas>("TopLeft2"));

        new Animation() {
            Duration = TimeSpan.FromSeconds(2),
            IterationCount = IterationCount.Infinite,
            PlaybackDirection = PlaybackDirection.Alternate,
            Children = {
                new KeyFrame {
                    Cue = default,
                    Setters = {
                        new Setter(Path.OpacityProperty, 0),
                    }
                },
                new KeyFrame {
                    Cue = new Cue(1),
                    Setters = {
                        new Setter(Path.OpacityProperty, 1),
                    },
                },
            }
        }.RunAsync(this.FindControl<Path>("Path8_Copy14"));
    }
}
