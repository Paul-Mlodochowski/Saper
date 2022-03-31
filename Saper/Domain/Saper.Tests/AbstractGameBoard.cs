namespace Saper.Domain.Saper.Tests
{
    public abstract class AbstractGameBoard : IGameBoard
    {
        public abstract int[,] Board { get; set; }
        public abstract int GetBoardTile(int a, int b);

        public abstract int GetSize();
        
    }
}
