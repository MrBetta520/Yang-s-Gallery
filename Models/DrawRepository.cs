using System.Collections.Generic;
namespace Assignment12._2._2.Models
{
    public class DrawRepository : IDraw
    {
        public List<Draw> Draws { get; set; }
        public DrawRepository()
        {
            Draws = new List<Draw>()
            {
                new Draw()
                {
                    Id = 101,
                    Author = "Leonardo Da Vinci",
                    Name = "Mona Lisa",
                    Description = "The Mona Lisa is an oil painting by Italian artist, inventor, and " +
                                  "writer Leonardo da Vinci. Likely completed in 1506, the piece features a " +
                                  "portrait of a seated woman set against an imaginary landscape. In addition " +
                                  "to being one of the most famous paintings, it is also the most valuable.",
                    Price = 561.30,
                    ImageUrl = "monalisa.jpg"
                },
                new Draw()
                {
                    Id = 102,
                    Author = "Van Gogh",
                    Name = "Sunflower",
                    Description = "Vincent painted a total of five large canvases with sunflowers in a vase, with " +
                                  "three shades of yellow 'and nothing else'. In this way, he demonstrated that it was " +
                                  "possible to create an image with numerous variations of a single colour, without any " +
                                  "loss of eloquence.",
                    Price = 191.40,
                    ImageUrl = "sunflower.jpg"
                },
                new Draw()
                {
                    Id = 103,
                    Author = "Jan Van Eyck",
                    Name = "Arnolfini Portrait",
                    Description = "The Arnolfini Portrait provides a clear pictorial record of the rank and social status" +
                                  " of the subjects. The woman's robe is trimmed with ermine fur and consists of an " +
                                  "inordinate amount of fabric. A personal maid would have been needed to accompany the " +
                                  "woman, to hold the garment off the ground.",
                    Price = 211.40,
                    ImageUrl = "arnolfiniPortrait.jpg"
                },
                new Draw()
                {
                    Id = 104,
                    Author = "Raphael",
                    Name = "The Sistine Madonna",
                    Description = "The Sistine Madonna is one of the world's most famous Renaissance masterpieces. " +
                                  "It depicts a vision appearing to saints in the clouds. In the centre of the picture " +
                                  "the Virgin strides towards the earthly realm whilst holding the Christ Child in her arms.",
                    Price = 365.00,
                    ImageUrl = "theSistineMadonna.jpg"
                },
                new Draw()
                {
                    Id = 105,
                    Author = "Caravaggio",
                    Name = "The Burial Of Jesus",
                    Description = "The burial of Jesus refers to the burial of the body of Jesus after crucifixion, before " +
                                  "the eve of the sabbath described in the New Testament. According to the canonical gospel " +
                                  "accounts, he was placed in a tomb by a councillor of the sanhedrin named Joseph of " +
                                  "Arimathea.",
                    Price = 481.00,
                    ImageUrl = "theBurialOfJesus.jpg"
                },
                new Draw()
                {
                    Id = 106,
                    Author = "Georges de la Tour",
                    Name = "The Magdalen With The Smoking Flame",
                    Description = "The Magdalene with the Smoking Flame portrays Mary Magdalene with a skull on her lap and " +
                                  "a brightly lit candle on the desk. She has her hand under her chin while staring at the " +
                                  "candle. There are two books placed on the desk, like the books in the other versions of the " +
                                  "paintings. One of the books is the Holy Bible.",
                    Price = 750.00,
                    ImageUrl = "theMagdalenWithTheSmokingFlame.jpg"
                }
            };
        }

        public void AddDraw(Draw draw)
        {
            Draws.Add(draw);
        }

        public void DeleteDraw(int? id)
        {
            var draw = Draws.Find(x => x.Id == id);
            Draws.Remove(draw);
        }

        public Draw GetDrawById(int? id)
        {
            if(id == null)
            {
                return null;
            }
            else
            {
                return Draws.Find(x => x.Id == id);
            }
        }

        public IEnumerable<Draw> InitializeDraw()
        {
            return Draws;
        }

        public void UpdateDraw(Draw draw)
        {
            var theDraw = Draws.Find(x => x.Id == draw.Id);
            if(theDraw != null)
            {
                theDraw.Price = draw.Price;
                theDraw.ImageUrl = draw.ImageUrl;
                theDraw.Description = draw.Description;
                theDraw.Id = draw.Id;
                theDraw.Author = draw.Author;
                theDraw.Name = draw.Name;
            }
        }
    }
}
