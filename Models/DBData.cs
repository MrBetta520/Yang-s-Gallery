using System.Collections.Generic;

namespace Assignment12._2._2.Models
{
    public class DBData : IDraw
    {
        public List<Draw> Draws { get ; set; }

        private DrawContext _drawContext;
        public DBData(DrawContext drawContext)
        {
            _drawContext = drawContext;
        }
        public void AddDraw(Draw draw)
        {
            if(draw.Country.ToString() == "Italy" )
            {
                draw.CountryId = 1;
            }
            if (draw.Country.ToString() == "Holland")
            {
                draw.CountryId = 2;
            }
            if (draw.Country.ToString() == "French")
            {
                draw.CountryId = 3;
            }

            _drawContext.Draws.Add(draw);
            _drawContext.SaveChanges();
        }

        public void DeleteDraw(int? id)
        {
            var draw = _drawContext.Draws.Find(id);
            if (draw != null)
            {
                _drawContext.Draws.Remove(draw);
                _drawContext.SaveChanges();
            }
        }

        public Draw GetDrawById(int? id)
        {
            return _drawContext.Draws.Find(id);
        }

        public IEnumerable<Draw> InitializeDraw()
        {
            return _drawContext.Draws;
        }

        public void UpdateDraw(Draw draw)
        {
            Draw theDraw = _drawContext.Draws.Find(draw.Id);
            if(theDraw != null)
            {
                theDraw.Id = draw.Id;
                theDraw.Author = draw.Author;
                theDraw.Description = draw.Description;
                theDraw.Price = draw.Price;
                theDraw.ImageUrl = draw.ImageUrl;
                theDraw.Name = draw.Name;
                if(draw.Country.ToString() == "Italy")
                {
                    theDraw.CountryId = 1;
                }
                if (draw.Country.ToString() == "Holland")
                {
                    theDraw.CountryId = 2;
                }
                if (draw.Country.ToString() == "French")
                {
                    theDraw.CountryId = 3;
                }
                _drawContext.SaveChanges();
            }
        }
    }
}
