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
                        },
                        new Hymns
                        {
                            Num = 51,
                            Name = "Sons of Michael, He Approaches"
                        }, new Hymns
                        {
                            Num = 52,
                            Name = "The Day Dawn is Breaking"
                        }, new Hymns
                        {
                            Num = 53,
                            Name = "Let Earth's Inhabitants Rejoice"
                        }, new Hymns
                        {
                            Num = 54,
                            Name = "Behold, the Mountain of the Lord"
                        }, new Hymns
                        {
                            Num = 55,
                            Name = "Lo, the Mighty God Appearing!"
                        }, new Hymns
                        {
                            Num = 56,
                            Name = "Softly Beams the Sacred Dawning"
                        }, new Hymns
                        {
                            Num = 57,
                            Name = "We're Not Ashamed to Own Our Lord"
                        }, new Hymns
                        {
                            Num = 58,
                            Name = "Come, Ye Children of the Lord"
                        }, new Hymns
                        {
                            Num = 59,
                            Name = "Come, Oh Thou King of Kings"
                        }, new Hymns
                        {
                            Num = 60,
                            Name = "Battle Hymn of the Republic"
                        },
                        new Hymns
                        {
                            Num = 61,
                            Name = "Raise Your Voices to the Lord"
                        }, new Hymns
                        {
                            Num = 62,
                            Name = "All Creatures of our God and King"
                        }, new Hymns
                        {
                            Num = 63,
                            Name = "Great King of Heaven"
                        }, new Hymns
                        {
                            Num = 64,
                            Name = "On This Day of Joy and Gladness"
                        }, new Hymns
                        {
                            Num = 65,
                            Name = "Come, All Ye Saints Who Dwell on Earth"
                        }, new Hymns
                        {
                            Num = 66,
                            Name = "Rejoice, the Lord is King!"
                        }, new Hymns
                        {
                            Num = 67,
                            Name = "Glory to God on High"
                        }, new Hymns
                        {
                            Num = 68,
                            Name = "A Mighty Fortress is Our God"
                        }, new Hymns
                        {
                            Num = 69,
                            Name = "All Glory Laud and Honor"
                        }, new Hymns
                        {
                            Num = 70,
                            Name = "Sing Praise to Him"
                        },
                        new Hymns
                        {
                            Num = 71,
                            Name = "With Songs of Praise"
                        }, new Hymns
                        {
                            Num = 72,
                            Name = "Praise to the Lord, the Almighty"
                        }, new Hymns
                        {
                            Num = 73,
                            Name = "Praise the Lord with Heart and Voice"
                        }, new Hymns
                        {
                            Num = 74,
                            Name = "Praise Ye the Lord"
                        }, new Hymns
                        {
                            Num = 75,
                            Name = "In Hymns of Praise"
                        }, new Hymns
                        {
                            Num = 76,
                            Name = "God of Our Father's We Come Unto Thee"
                        }, new Hymns
                        {
                            Num = 77,
                            Name = "Great is the Lord"
                        }, new Hymns
                        {
                            Num = 78,
                            Name = "God of Our Fathers, We Come Unto Thee"
                        }, new Hymns
                        {
                            Num = 79,
                            Name = "With All the Power of Heart and Tongue"
                        }, new Hymns
                        {
                            Num = 80,
                            Name = "God of Our Fathers, Known of Old"
                        },
                        new Hymns
                        {
                            Num = 81,
                            Name = "Press Forward, Saints"
                        }, new Hymns
                        {
                            Num = 82,
                            Name = "For All the Saints"
                        }, new Hymns
                        {
                            Num = 83,
                            Name = "Guide Us, O Thou Great Jehovah"
                        }, new Hymns
                        {
                            Num = 84,
                            Name = "Faith of Our Fathers"
                        }, new Hymns
                        {
                            Num = 85,
                            Name = "How Firm a Foundation"
                        }, new Hymns
                        {
                            Num = 86,
                            Name = "How Great Thou Art"
                        }, new Hymns
                        {
                            Num = 87,
                            Name = "God is Love"
                        }, new Hymns
                        {
                            Num = 88,
                            Name = "Great God, Attend While Zion Sings"
                        }, new Hymns
                        {
                            Num = 89,
                            Name = "The Lord is My Light"
                        }, new Hymns
                        {
                            Num = 90,
                            Name = "From All That Dwell below the Skies"
                        },
                        new Hymns
                        {
                            Num = 91,
                            Name = "Father, Thy Children to Thee Now Raise"
                        }, new Hymns
                        {
                            Num = 92,
                            Name = "For the Beauty of the Earth"
                        }, new Hymns
                        {
                            Num = 93,
                            Name = "Prayer of Thanksgiving"
                        }, new Hymns
                        {
                            Num = 94,
                            Name = "Come, Ye Thankful People"
                        }, new Hymns
                        {
                            Num = 95,
                            Name = "Now Thank We All Our God"
                        }, new Hymns
                        {
                            Num = 96,
                            Name = "Dearest Children, God Is Near You"
                        }, new Hymns
                        {
                            Num = 97,
                            Name = "Lead, Kindly Light"
                        }, new Hymns
                        {
                            Num = 98,
                            Name = "I Need Thee Every Hour"
                        }, new Hymns
                        {
                            Num = 99,
                            Name = "Nearer, Dear Savior, to Thee"
                        }, new Hymns
                        {
                            Num = 100,
                            Name = "Nearer, My God, to Thee"
                        },
                        new Hymns
                        {
                            Num = 101,
                            Name = "Guide Me to Thee"
                        }, new Hymns
                        {
                            Num = 102,
                            Name = "Jesus, Lover of My Soul"
                        }, new Hymns
                        {
                            Num = 103,
                            Name = "Precious Savior, Dear Redeemer"
                        }, new Hymns
                        {
                            Num = 104,
                            Name = "Jesus, Savior, Pilot Me"
                        }, new Hymns
                        {
                            Num = 105,
                            Name = "Master, the Tempest is Raging"
                        }, new Hymns
                        {
                            Num = 106,
                            Name = "God Speed the Right"
                        }, new Hymns
                        {
                            Num = 107,
                            Name = "Lord, Accept Our True Devotion"
                        }, new Hymns
                        {
                            Num = 108,
                            Name = "The Lord is My Shepherd"
                        }, new Hymns
                        {
                            Num = 109,
                            Name = "The Lord My Pastrue Will Prepare"
                        }, new Hymns
                        {
                            Num = 110,
                            Name = "Cast Thy Burden upon the Lord"
                        },
                        new Hymns
                        {
                            Num = 111,
                            Name = "Rock of Ages"
                        }, new Hymns
                        {
                            Num = 112,
                            Name = "Savior, Redeemer of My Soul"
                        }, new Hymns
                        {
                            Num = 113,
                            Name = "Our Savior's Love"
                        }, new Hymns
                        {
                            Num = 114,
                            Name = "Come Unto Him"
                        }, new Hymns
                        {
                            Num = 115,
                            Name = "Come, Ye Disconsolate"
                        }, new Hymns
                        {
                            Num = 116,
                            Name = "Come, Follow Me"
                        }, new Hymns
                        {
                            Num = 117,
                            Name = "Come unto Jesus"
                        }, new Hymns
                        {
                            Num = 118,
                            Name = "Ye Simple Souls Who Stray"
                        }, new Hymns
                        {
                            Num = 119,
                            Name = "Come, We That Love the Lord"
                        }, new Hymns
                        {
                            Num = 120,
                            Name = "Lean on My Ample Arm"
                        }

                        );
                    context.SaveChanges();


                }
            }
        }
    }
}
