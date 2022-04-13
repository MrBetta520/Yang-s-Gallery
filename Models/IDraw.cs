using System.Collections.Generic;

namespace Assignment12._2._2.Models
{
    public interface IDraw
    {
        List<Draw> Draws { get; set; }
        IEnumerable<Draw> InitializeDraw();
        Draw GetDrawById(int? id); 
        void AddDraw(Draw draw);
        void DeleteDraw(int? id);
        void UpdateDraw(Draw draw);
    }
}
