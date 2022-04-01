namespace Saper.Models.SaperLogic
{
    public interface IGameBoard
    {
        
        int GetSize();
        int[,] ClickedXY();

    }
    public enum Tile
    {
        DiffrentThan0 = 0,
        Checked = 1
    }
}
