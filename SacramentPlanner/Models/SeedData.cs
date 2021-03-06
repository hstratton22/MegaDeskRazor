using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SacramentPlanner.Data;
using System.Linq;

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
                        Conductor = "Bishop Rick Smith",
                        OpeningSong = "201 - Joy to the World",
                        OpeningPrayer = "Abraham Lincoln",
                        SacramentSong = "171 - In Humility, Our Savior",
                        ClosingSong = "206 - Away in a Manger",
                        ClosingPrayer = "Jane Adams",
                        SpeakerSubjects = "Christmas",
                    },

                    
                new Plan
                {
                    Date = DateTime.Parse("2021-12-12"),
                    Conductor = "Bishop Rick Smith",
                    OpeningSong = "202 - Oh, Come All Ye Faithful",
                    OpeningPrayer = "John Adams",
                    SacramentSong = "172 - With Humble Heart",
                    IntermediateSong = "212 - Far, Far Away on Judea's Plains",
                    ClosingSong = "213 - The First Noel",
                    ClosingPrayer = "Lucy Smith",
                    SpeakerSubjects = "Christmas",
                }

                    );
                context.SaveChanges();
            }


            using (var context = new SacramentPlannerContext(serviceProvider.GetRequiredService<DbContextOptions<SacramentPlannerContext>>()))
            {
                if (context.Speakers.Any())
                {
                    return;
                }
                var speakers = new Speaker[]
                {
                new Speaker{PlanID=2,FirstMidName="Ebenezer",LastName="Scrooge",},
                new Speaker{PlanID=2,FirstMidName="Alvin",LastName="Smith"},
                new Speaker{PlanID=2,FirstMidName="Anakin",LastName="Skywalker",},
                new Speaker{PlanID=2,FirstMidName="Barty",LastName="Crouch",}
                };
                foreach (Speaker s in speakers)
                {
                    context.Speakers.Add(s);
                }
                context.SaveChanges();;
            }

            using (var context = new SacramentPlannerContext(serviceProvider.GetRequiredService<DbContextOptions<SacramentPlannerContext>>()))
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
                    }, new Hymns
                    {
                        Num = 121,
                        Name = "I'm A Pilgrim, I'm a Stranger"
                    }, new Hymns
                    {
                        Num = 122,
                        Name = "Though Deepening Trials"
                    }, new Hymns
                    {
                        Num = 123,
                        Name = "Oh, May My Soul Commune with Thee"
                    }, new Hymns
                    {
                        Num = 124,
                        Name = "Be Still, My Soul"
                    }, new Hymns
                    {
                        Num = 125,
                        Name = "How Gentle God's Commands"
                    }, new Hymns
                    {
                        Num = 126,
                        Name = "How Long, O Lord Most Holy and True"
                    }, new Hymns
                    {
                        Num = 127,
                        Name = "Does the Journey Seem Long?"
                    }, new Hymns
                    {
                        Num = 128,
                        Name = "When Faith Endures"
                    }, new Hymns
                    {
                        Num = 129,
                        Name = "Where Can I Turn for Peace?"
                    }, new Hymns
                    {
                        Num = 130,
                        Name = "Be Thou Humble"
                    }, new Hymns
                    {
                        Num = 131,
                        Name = "More Holiness Give Me"
                    }, new Hymns
                    {
                        Num = 132,
                        Name = "God Is in His Holy Temple"
                    }, new Hymns
                    {
                        Num = 133,
                        Name = "Father in Heaven"
                    }, new Hymns
                    {
                        Num = 134,
                        Name = "I Believe in Christ"
                    }, new Hymns
                    {
                        Num = 135,
                        Name = "My Redeemer Lives"
                    }, new Hymns
                    {
                        Num = 136,
                        Name = "I Know That My Redeemer Lives"
                    }, new Hymns
                    {
                        Num = 137,
                        Name = "Testimony"
                    }, new Hymns
                    {
                        Num = 138,
                        Name = "Bless Our Fast, We Pray"
                    }, new Hymns
                    {
                        Num = 139,
                        Name = "In Fasting We Approach Thee"
                    }, new Hymns
                    {
                        Num = 140,
                        Name = "Did You Think to Pray?"
                    }, new Hymns
                    {
                        Num = 141,
                        Name = "Jesus, the Very Though of Thee"
                    }, new Hymns
                    {
                        Num = 142,
                        Name = "Sweet Hour of Prayer"
                    }, new Hymns
                    {
                        Num = 143,
                        Name = "Let the Holy Spirit Guide"
                    }, new Hymns
                    {
                        Num = 144,
                        Name = "Secret Prayer"
                    }, new Hymns
                    {
                        Num = 145,
                        Name = "Prayer is the Soul's Sincere Desire"
                    }, new Hymns
                    {
                        Num = 146,
                        Name = "Gently Raise the Sacred Strain"
                    }, new Hymns
                    {
                        Num = 147,
                        Name = "Sweet is the Work"
                    }, new Hymns
                    {
                        Num = 148,
                        Name = "Sabbath Day"
                    }, new Hymns
                    {
                        Num = 149,
                        Name = "As the Dew from Heaven Distilling"
                    }, new Hymns
                    {
                        Num = 150,
                        Name = "O Thou Kind and Gracious Father"
                    }, new Hymns
                    {
                        Num = 151,
                        Name = "We Meet, Dear Lord"
                    }
                    , new Hymns
                    {
                        Num = 152,
                        Name = "God Be with You Till We Meet Again"
                    }, new Hymns
                    {
                        Num = 153,
                        Name = "Lord We Ask Thee Ere We Part"
                    }, new Hymns
                    {
                        Num = 154,
                        Name = "Father, This Hour Has Been One of Joy"
                    }, new Hymns
                    {
                        Num = 155,
                        Name = "We Have Partaken of Thy Love"
                    }, new Hymns
                    {
                        Num = 156,
                        Name = "Sing We Now at Parting"
                    }, new Hymns
                    {
                        Num = 157,
                        Name = "Thy Spirit, Lord, Has Stirred Our Souls"
                    }, new Hymns
                    {
                        Num = 158,
                        Name = "Before Thee, Lord, I Bow My Head"
                    }, new Hymns
                    {
                        Num = 159,
                        Name = "Now the Day is Over"
                    }, new Hymns
                    {
                        Num = 160,
                        Name = "Softly Now the Light of Day"
                    }, new Hymns
                    {
                        Num = 161,
                        Name = "The Lord Be with Us"
                    }, new Hymns
                    {
                        Num = 162,
                        Name = "Lord, We Come Before Thee Now"
                    }, new Hymns
                    {
                        Num = 163,
                        Name = "Lord, Dismiss Us with Thy Blessing"
                    }, new Hymns
                    {
                        Num = 164,
                        Name = "Great God, to Thee My Evening Song"
                    }, new Hymns
                    {
                        Num = 165,
                        Name = "Abide with Me; 'Tis Eventide"
                    }, new Hymns
                    {
                        Num = 166,
                        Name = "Abide with Me"
                    }, new Hymns
                    {
                        Num = 167,
                        Name = "Come, Let Us Sing an Evening Hymn"
                    }, new Hymns
                    {
                        Num = 168,
                        Name = "As the Shadows Fall"
                    }, new Hymns
                    {
                        Num = 169,
                        Name = "As Now We Take the Sacrament"
                    }, new Hymns
                    {
                        Num = 170,
                        Name = "God, Our Father, Hear Us Pray"
                    }, new Hymns
                    {
                        Num = 171,
                        Name = "With Humble Heart"
                    }, new Hymns
                    {
                        Num = 172,
                        Name = "In Humility, Our Savior"
                    }, new Hymns
                    {
                        Num = 173,
                        Name = "While of These Emblems We Partake"
                    }, new Hymns
                    {
                        Num = 174,
                        Name = "While of These Emblems We Partake"
                    }, new Hymns
                    {
                        Num = 175,
                        Name = "O God, the Eternal Father"
                    }, new Hymns
                    {
                        Num = 176,
                        Name = "'Tis Sweet to Sing the Matchless Love"
                    }, new Hymns
                    {
                        Num = 177,
                        Name = "'Tis Sweet to Sing the Matchless Love"
                    }, new Hymns
                    {
                        Num = 178,
                        Name = "O Lord of Hosts"
                    }, new Hymns
                    {
                        Num = 179,
                        Name = "Again, Our Dear Redeeming Lord"
                    }, new Hymns
                    {
                        Num = 180,
                        Name = "Father in Heaven, We Do Believe"
                    }, new Hymns
                    {
                        Num = 181,
                        Name = "Jesus of Nazareth, Savior and King"
                    }, new Hymns
                    {
                        Num = 182,
                        Name = "We'll Sing All Hail to Jesus' Name"
                    }, new Hymns
                    {
                        Num = 183,
                        Name = "In Rememberance of Thy Suffering"
                    }, new Hymns
                    {
                        Num = 184,
                        Name = "Upon the Cross of Calvary"
                    }, new Hymns
                    {
                        Num = 185,
                        Name = "Reverently and Meekly Now"
                    }, new Hymns
                    {
                        Num = 186,
                        Name = "Again We Meet around the Board"
                    }, new Hymns
                    {
                        Num = 187,
                        Name = "God Loved Us, So He Sent His Son"
                    }, new Hymns
                    {
                        Num = 188,
                        Name = "Thy Will, O Lord, Be Done"
                    }, new Hymns
                    {
                        Num = 189,
                        Name = "O Thou, Before the World Began"
                    }, new Hymns
                    {
                        Num = 190,
                        Name = "In Memory of the Crucified"
                    }, new Hymns
                    {
                        Num = 191,
                        Name = "Behold the Great Redeemer Die"
                    }, new Hymns
                    {
                        Num = 192,
                        Name = "He Died! The Great Redeemer Died"
                    }, new Hymns
                    {
                        Num = 193,
                        Name = "I Stand All Amazed"
                    }, new Hymns
                    {
                        Num = 194,
                        Name = "There is a Green Hill Far Away"
                    }, new Hymns
                    {
                        Num = 195,
                        Name = "How Great the Wisdom and the Love"
                    }, new Hymns
                    {
                        Num = 196,
                        Name = "Jesus, Once of Humble Birth"
                    }, new Hymns
                    {
                        Num = 197,
                        Name = "O Savior, Thou Who Wearest a Crown"
                    }, new Hymns
                    {
                        Num = 198,
                        Name = "That Easter Morn"
                    }, new Hymns
                    {
                        Num = 199,
                        Name = "He is Risen!"
                    }, new Hymns
                    {
                        Num = 200,
                        Name = "Christ the Lord is Risen Today"
                    }, new Hymns
                    {
                        Num = 201,
                        Name = "Joy to the World"
                    }, new Hymns
                    {
                        Num = 202,
                        Name = "Oh, Come All Ye Faithful"
                    }, new Hymns
                    {
                        Num = 203,
                        Name = "Angels We Have Heard on High"
                    }, new Hymns
                    {
                        Num = 204,
                        Name = "Silent Night"
                    }, new Hymns
                    {
                        Num = 205,
                        Name = "Once in Royal David's City"
                    }, new Hymns
                    {
                        Num = 206,
                        Name = "Away in a Manger"
                    }, new Hymns
                    {
                        Num = 207,
                        Name = "It Came Upon a Midnight Clear"
                    }, new Hymns
                    {
                        Num = 208,
                        Name = "O Little Town of Bethlehem"
                    }, new Hymns
                    {
                        Num = 209,
                        Name = "Hark! The Herald Angels Sing"
                    }, new Hymns
                    {
                        Num = 210,
                        Name = "With Wondering Awe"
                    }, new Hymns
                    {
                        Num = 211,
                        Name = "While Shepherd Watched Their Flocks"
                    }, new Hymns
                    {
                        Num = 212,
                        Name = "Far, Far Away on Judea's Plains"
                    }, new Hymns
                    {
                        Num = 213,
                        Name = "The First Noel"
                    }, new Hymns
                    {
                        Num = 214,
                        Name = "I Heard the Bells on Christmas Day"
                    }, new Hymns
                    {
                        Num = 215,
                        Name = "Ring Out, Wild Bells"
                    }, new Hymns
                    {
                        Num = 216,
                        Name = "We are Sowing"
                    }, new Hymns
                    {
                        Num = 217,
                        Name = "Come, Let Us Anew"
                    }, new Hymns
                    {
                        Num = 218,
                        Name = "We Give Thee But Thine Own"
                    }, new Hymns
                    {
                        Num = 219,
                        Name = "Because I Have Been Given Much"
                    }, new Hymns
                    {
                        Num = 220,
                        Name = "Lord, I Would Follow Thee"
                    }, new Hymns
                    {
                        Num = 221,
                        Name = "Dear to the Heart of Shepherd"
                    }, new Hymns
                    {
                        Num = 222,
                        Name = "Hear Thou Our Hymn, O Lord"
                    }, new Hymns
                    {
                        Num = 223,
                        Name = "Have I Done Any Good?"
                    }, new Hymns
                    {
                        Num = 224,
                        Name = "I Have Work Enough to Do"
                    }, new Hymns
                    {
                        Num = 225,
                        Name = "We Are Marching On to Glory"
                    }, new Hymns
                    {
                        Num = 226,
                        Name = "Improve the Shining Moments"
                    }, new Hymns
                    {
                        Num = 227,
                        Name = "There Is Sunshine in My Soul Today"
                    }, new Hymns
                    {
                        Num = 228,
                        Name = "You Can Make the Pathway Bright"
                    }, new Hymns
                    {
                        Num = 229,
                        Name = "Today, While the Sun Shines"
                    }, new Hymns
                    {
                        Num = 230,
                        Name = "Scatter Sunshine"
                    }, new Hymns
                    {
                        Num = 231,
                        Name = "Father, Cheer Our Souls Tonight"
                    }, new Hymns
                    {
                        Num = 232,
                        Name = "Let Us Oft Speak Kind Words"
                    }, new Hymns
                    {
                        Num = 233,
                        Name = "Nay, Speak No Ill"
                    }, new Hymns
                    {
                        Num = 234,
                        Name = "Jesus, Mighty King in Zion"
                    }, new Hymns
                    {
                        Num = 235,
                        Name = "Should You Feel Inclined to Censure"
                    }, new Hymns
                    {
                        Num = 236,
                        Name = "Lord, Accept into Thy Kingdom"
                    }, new Hymns
                    {
                        Num = 237,
                        Name = "Do What is Right"
                    }, new Hymns
                    {
                        Num = 238,
                        Name = "Behold Thy Sons and Daughters, Lord"
                    }, new Hymns
                    {
                        Num = 239,
                        Name = "Choose the Right"
                    }, new Hymns
                    {
                        Num = 240,
                        Name = "Know This, That Every Soul is Free"
                    }, new Hymns
                    {
                        Num = 241,
                        Name = "Count Your Blessings"
                    }, new Hymns
                    {
                        Num = 242,
                        Name = "Praise God, from Whom All Blessings Flow"
                    }, new Hymns
                    {
                        Num = 243,
                        Name = "Let Us All Press On"
                    }, new Hymns
                    {
                        Num = 244,
                        Name = "Come Along, Come Along"
                    }, new Hymns
                    {
                        Num = 245,
                        Name = "This House We Dedicate to Thee"
                    }, new Hymns
                    {
                        Num = 246,
                        Name = "Onward, Christian Soldiers"
                    }, new Hymns
                    {
                        Num = 247,
                        Name = "We Love Thy House, O God"
                    }, new Hymns
                    {
                        Num = 248,
                        Name = "Up, Awake, Ye Defenders of Zion"
                    }, new Hymns
                    {
                        Num = 249,
                        Name = "Called to Serve"
                    }, new Hymns
                    {
                        Num = 250,
                        Name = "We Are All Enlisted"
                    }, new Hymns
                    {
                        Num = 251,
                        Name = "Behold! A Royal Army"
                    }, new Hymns
                    {
                        Num = 252,
                        Name = "Put Your Shoulder to the Wheel"
                    }, new Hymns
                    {
                        Num = 253,
                        Name = "Like Ten Thousand Legions Marching"
                    }, new Hymns
                    {
                        Num = 254,
                        Name = "True to the Faith"
                    }, new Hymns
                    {
                        Num = 255,
                        Name = "Carry On"
                    }, new Hymns
                    {
                        Num = 256,
                        Name = "As Zion's Youth in Latter Days"
                    }, new Hymns
                    {
                        Num = 257,
                        Name = "Rejoice! A Glorious Sound is Heard"
                    }, new Hymns
                    {
                        Num = 258,
                        Name = "O Thou Rock of Our Salvation"
                    }, new Hymns
                    {
                        Num = 259,
                        Name = "Hope of Israel"
                    }, new Hymns
                    {
                        Num = 260,
                        Name = "Who's on the Lord's Side?"
                    }, new Hymns
                    {
                        Num = 261,
                        Name = "Thy Servants Are Prepared"
                    }, new Hymns
                    {
                        Num = 262,
                        Name = "Go, Ye Messengers of Glory"
                    }, new Hymns
                    {
                        Num = 263,
                        Name = "Go Forth with Faith"
                    }, new Hymns
                    {
                        Num = 264,
                        Name = "Hark, All Ye Nations!"
                    }, new Hymns
                    {
                        Num = 265,
                        Name = "Arise, O God, and Shine"
                    }, new Hymns
                    {
                        Num = 266,
                        Name = "The Time is Far Spent"
                    }, new Hymns
                    {
                        Num = 267,
                        Name = "How Wonderous and Great"
                    }, new Hymns
                    {
                        Num = 268,
                        Name = "Come, All Whose Souls Are Lighted"
                    }, new Hymns
                    {
                        Num = 269,
                        Name = "Johovah, Lord of Heaven and Earth"
                    }, new Hymns
                    {
                        Num = 270,
                        Name = "I'll Go Where You Want Me to Go"
                    }, new Hymns
                    {
                        Num = 271,
                        Name = "Oh, Holy Words of Truth and Love"
                    }, new Hymns
                    {
                        Num = 272,
                        Name = "Oh Say, What is Truth?"
                    }, new Hymns
                    {
                        Num = 273,
                        Name = "Truth Reflects Upon Our Senses"
                    }, new Hymns
                    {
                        Num = 274,
                        Name = "The Iron Rod"
                    }, new Hymns
                    {
                        Num = 275,
                        Name = "Men Are That They Might Have Joy"
                    }, new Hymns
                    {
                        Num = 276,
                        Name = "Come Away to the Sunday School"
                    }, new Hymns
                    {
                        Num = 277,
                        Name = "As I Search the Holy Scriptures"
                    }, new Hymns
                    {
                        Num = 278,
                        Name = "Thanks for the Sabbath School"
                    }, new Hymns
                    {
                        Num = 279,
                        Name = "Thy Holy Word"
                    }, new Hymns
                    {
                        Num = 280,
                        Name = "Welcome, Welcome, Sabbath Morning"
                    }, new Hymns
                    {
                        Num = 281,
                        Name = "Help Me Teach with Inspiration"
                    }, new Hymns
                    {
                        Num = 282,
                        Name = "We Meet Again in Sabbath School"
                    }, new Hymns
                    {
                        Num = 283,
                        Name = "The Glorious Gospel Light Has Shone"
                    }, new Hymns
                    {
                        Num = 284,
                        Name = "If You Could Hie to Kolob"
                    }, new Hymns
                    {
                        Num = 285,
                        Name = "God Moves in a Mysterious Way"
                    }, new Hymns
                    {
                        Num = 286,
                        Name = "Oh, What Songs of the Heart"
                    }, new Hymns
                    {
                        Num = 287,
                        Name = "Rise, Ye Saints, and Temples Enter"
                    }, new Hymns
                    {
                        Num = 288,
                        Name = "How Beautiful Thy Temples, Lord"
                    }, new Hymns
                    {
                        Num = 289,
                        Name = "Holy Temples on Mount Zion"
                    }, new Hymns
                    {
                        Num = 290,
                        Name = "Rejpoice, Ye Saints of Latter Days"
                    }, new Hymns
                    {
                        Num = 291,
                        Name = "Turn Your Hearts"
                    }, new Hymns
                    {
                        Num = 292,
                        Name = "O My Father"
                    }, new Hymns
                    {
                        Num = 293,
                        Name = "Each Life That Touches Ours for Good"
                    }, new Hymns
                    {
                        Num = 294,
                        Name = "Love at Home"
                    }, new Hymns
                    {
                        Num = 295,
                        Name = "O Love That Glorifies the Son"
                    }, new Hymns
                    {
                        Num = 296,
                        Name = "Our Father, by Whose Name"
                    }, new Hymns
                    {
                        Num = 297,
                        Name = "From Home of Saints Glad Songs Arise"
                    }, new Hymns
                    {
                        Num = 298,
                        Name = "Home Can Be a Heaven on Earth"
                    }, new Hymns
                    {
                        Num = 299,
                        Name = "Children of Our Heavenly Father"
                    }, new Hymns
                    {
                        Num = 300,
                        Name = "Familes Can Be Together Forever"
                    }, new Hymns
                    {
                        Num = 301,
                        Name = "I Am a Child of God"
                    }, new Hymns
                    {
                        Num = 302,
                        Name = "I Know My Father Lives"
                    }, new Hymns
                    {
                        Num = 303,
                        Name = "Keep the Commandments"
                    }, new Hymns
                    {
                        Num = 304,
                        Name = "Teach Me to Walk in the LIght"
                    }, new Hymns
                    {
                        Num = 305,
                        Name = "The Light Devine"
                    }, new Hymns
                    {
                        Num = 306,
                        Name = "God's Daily Care"
                    }, new Hymns
                    {
                        Num = 307,
                        Name = "In Our Lovely Deseret"
                    }, new Hymns
                    {
                        Num = 308,
                        Name = "Love One Another"
                    }, new Hymns
                    {
                        Num = 309,
                        Name = "As Sisters in Zion (Women)"
                    }, new Hymns
                    {
                        Num = 310,
                        Name = "A Key Was Turned in Latter Days (Women)"
                    }, new Hymns
                    {
                        Num = 311,
                        Name = "We Meet Again as Sisters (Women)"
                    }, new Hymns
                    {
                        Num = 312,
                        Name = "We ever Pray for thee (Women)"
                    }, new Hymns
                    {
                        Num = 313,
                        Name = "God is Love (Women)"
                    }, new Hymns
                    {
                        Num = 314,
                        Name = "How Gentle God's Commandments (Women)"
                    }, new Hymns
                    {
                        Num = 315,
                        Name = "Jesus, the Very Thought of Thee (Women)"
                    }, new Hymns
                    {
                        Num = 316,
                        Name = "The Lord is My Shepherd"
                    }, new Hymns
                    {
                        Num = 317,
                        Name = "Sweet is the Work (Women)"
                    }, new Hymns
                    {
                        Num = 318,
                        Name = "Love at Home"
                    }, new Hymns
                    {
                        Num = 319,
                        Name = "Ye Elders of Israel"
                    }, new Hymns
                    {
                        Num = 320,
                        Name = "The Priesthood of Our Lord"
                    }, new Hymns
                    {
                        Num = 321,
                        Name = "Ye Who Are Called to Labor (Men)"
                    }, new Hymns
                    {
                        Num = 322,
                        Name = "Come, All Ye Sons of God (Men)"
                    }, new Hymns
                    {
                        Num = 323,
                        Name = "Rise Up, O Men of God (Men)"
                    }, new Hymns
                    {
                        Num = 324,
                        Name = "Rise Up, O Men of God (Men)"
                    }, new Hymns
                    {
                        Num = 325,
                        Name = "See the Mighty Priesthood Gathered (Men)"
                    }, new Hymns
                    {
                        Num = 326,
                        Name = "Come, Come, Ye Saints"
                    }, new Hymns
                    {
                        Num = 327,
                        Name = "Go, Ye Messengers of Heaven (Men)"
                    }, new Hymns
                    {
                        Num = 328,
                        Name = "An Angel From on High"
                    }, new Hymns
                    {
                        Num = 329,
                        Name = "Thy Servants Are Prepared (Men)"
                    }, new Hymns
                    {
                        Num = 330,
                        Name = "See, the Mighty Angel Flying (Men)"
                    }, new Hymns
                    {
                        Num = 331,
                        Name = "Oh Say, What is Truth? (Men)"
                    }, new Hymns
                    {
                        Num = 332,
                        Name = "Come, O Thou King of Kings (Men)"
                    }, new Hymns
                    {
                        Num = 333,
                        Name = "High on the Mountain Top"
                    }, new Hymns
                    {
                        Num = 334,
                        Name = "I Need Thee Every Hour (Men)"
                    }, new Hymns
                    {
                        Num = 335,
                        Name = "Brightly Beams Our Father's Mercy (Men)"
                    }, new Hymns
                    {
                        Num = 336,
                        Name = "School Thy Feelings (Men)"
                    }, new Hymns
                    {
                        Num = 337,
                        Name = "O Home Beloved (Men)"
                    }, new Hymns
                    {
                        Num = 338,
                        Name = "America the Beautiful"
                    }, new Hymns
                    {
                        Num = 339,
                        Name = "My Country, 'Tis of Thee"
                    }, new Hymns
                    {
                        Num = 340,
                        Name = "The Star-Spangled Banner"
                    }, new Hymns
                    {
                        Num = 341,
                        Name = "God Save the King"
                    }

                    );
                context.SaveChanges();


               
            }
        }
    }
}
