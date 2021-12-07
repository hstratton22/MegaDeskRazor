using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SacramentPlanner.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlanner.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SacramentPlannerContext(serviceProvider.GetRequiredService<DbContextOptions<SacramentPlannerContext>>()))
            {
                if (context.Plan.Any())
                {
                    return;
                }
                context.Plan.AddRange(
                    new Plan
                    {
                        Date = DateTime.Parse("2021-12-4"),
                        Conductor = "Bishop",
                        OpeningSong = 201,
                        OpeningPrayer = "John Doe",
                        SacramentSong = 171,
                        IntermediateSong = 212,
                        ClosingSong = 206,
                        ClosingPrayer = "Jane Doe",
                        SpeakerSubjects = "Christmas",
                        NumberSpeakers = 2

                    }

                    );
                context.SaveChanges();
                //}

                {
                    if (context.Hymns.Any())
                    {
                        return;
                    }
                    context.Hymns.AddRange(
                        new Hymns
                        {
                            Num = 1,
                            Name = "The Morning Breaks"
                        },
                        new Hymns
                        {
                            Num = 2,
                            Name = "The Spirit of God"
                        },
                        new Hymns
                        {
                            Num = 3,
                            Name = "Now Let Us Rejoice"
                        },
                        new Hymns
                        {
                            Num = 4,
                            Name = "Truth Eternal"
                        },
                        new Hymns
                        {
                            Num = 5,
                            Name = "High on the Mountain Top"
                        },
                        new Hymns
                        {
                            Num = 6,
                            Name = "Redeemer of Israel"
                        },
                        new Hymns
                        {
                            Num = 7,
                            Name = "Israel, Israel God is Calling"
                        },
                        new Hymns
                        {
                            Num = 8,
                            Name = "Awake and Arise"
                        },
                        new Hymns
                        {
                            Num = 9,
                            Name = "Come, Rejoice"
                        },
                        new Hymns
                        {
                            Num = 10,
                            Name = "Come, Sing to the Lord"
                        },
                        new Hymns
                        {
                            Num = 11,
                            Name = "What Was Witnessed in the Heavens?"
                        },
                        new Hymns
                        {
                            Num = 12,
                            Name = "'Twas Witnessesd in the Morning Sky"
                        },
                        new Hymns
                        {
                            Num = 13,
                            Name = "The Morning Breaks"
                        },
                        new Hymns
                        {
                            Num = 14,
                            Name = "An Angel from on High"
                        },
                        new Hymns
                        {
                            Num = 15,
                            Name = "I Saw a Mighty Angel Fly"
                        },
                        new Hymns
                        {
                            Num = 16,
                            Name = "What Glorious Scenes Mine Eyes Behold"
                        },
                        new Hymns
                        {
                            Num = 17,
                            Name = "Awake, Ye Saints of God, Awake!"
                        },
                        new Hymns
                        {
                            Num = 18,
                            Name = "The Voice of God Again is Heard"
                        },
                        new Hymns
                        {
                            Num = 19,
                            Name = "We Thank Thee, O God, for a Prophet"
                        },
                        new Hymns
                        {
                            Num = 20,
                            Name = "God of Power, God of Right"
                        },
                        new Hymns
                        {
                            Num = 21,
                            Name = "Come, Listen to a Prophet's Voice"
                        },
                        new Hymns
                        {
                            Num = 22,
                            Name = "We Listen to a Prophet's Voice"
                        },
                        new Hymns
                        {
                            Num = 23,
                            Name = "We Ever Pray for Thee"
                        },
                        new Hymns
                        {
                            Num = 24,
                            Name = "God Bless Our Prophet Dear"
                        },
                        new Hymns
                        {
                            Num = 25,
                            Name = "Now We'll Sing with One Accord"
                        },
                        new Hymns
                        {
                            Num = 26,
                            Name = "Joseph Smith's First Prayer"
                        },
                        new Hymns
                        {
                            Num = 27,
                            Name = "Praise to the Man"
                        }, new Hymns
                        {
                            Num = 28,
                            Name = "Saints, Behold How Great Jehovah"
                        }, new Hymns
                        {
                            Num = 29,
                            Name = "A Poor Wayfaring Man of Grief"
                        },
                        new Hymns
                        {
                            Num = 30,
                            Name = "Come, Come Ye Saints"
                        },
                        new Hymns
                        {
                            Num = 31,
                            Name = "O God, Our Help in Ages Past"
                        }, new Hymns
                        {
                            Num = 32,
                            Name = "The Happy Day at Last Has Come"
                        }, new Hymns
                        {
                            Num = 33,
                            Name = "Our Mountain Home So Dear"
                        }, new Hymns
                        {
                            Num = 34,
                            Name = "O Ye Mountains High"
                        }, new Hymns
                        {
                            Num = 35,
                            Name = "For the Strength of the Hills"
                        }, new Hymns
                        {
                            Num = 36,
                            Name = "They, the Buildiers of the Nation"
                        }, new Hymns
                        {
                            Num = 37,
                            Name = "The Wintry Day, Descending to its Close"
                        }, new Hymns
                        {
                            Num = 38,
                            Name = "Come, All Ye Saints of Zion"
                        }, new Hymns
                        {
                            Num = 39,
                            Name = "O Saint of Zion"
                        }, new Hymns
                        {
                            Num = 40,
                            Name = "Arise, O Glorious Zion"
                        },
                        new Hymns
                        {
                            Num = 41,
                            Name = "Let Zion in Her Beauty Rise"
                        }, new Hymns
                        {
                            Num = 42,
                            Name = "Hail to the Brightness of Zion's Glad Morning!"
                        }, new Hymns
                        {
                            Num = 43,
                            Name = "Zion Stands with Hills Surrounded"
                        }, new Hymns
                        {
                            Num = 44,
                            Name = "Beautiful Zion, Built Above"
                        }, new Hymns
                        {
                            Num = 45,
                            Name = "Lead Me into Life Eternal"
                        }, new Hymns
                        {
                            Num = 46,
                            Name = "Glorious Things of Thee Are Spoken"
                        }, new Hymns
                        {
                            Num = 47,
                            Name = "We Will Sing of Zion"
                        }, new Hymns
                        {
                            Num = 48,
                            Name = "Gloriuos Things Are Sung of Zion"
                        }, new Hymns
                        {
                            Num = 49,
                            Name = "Adam-ondi-Ahman"
                        }, new Hymns
                        {
                            Num = 50,
                            Name = "Come, Thou Glorious Day of Promise"
                        }

                        );
                    context.SaveChanges();


                }
            }
        }
    }
}
