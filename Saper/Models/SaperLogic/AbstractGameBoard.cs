namespace Saper.Models.SaperLogic
{
    public abstract class AbstractGameBoard : IGameBoard
    {
        

        public abstract int[,] Board { get; set; }
        

        public abstract int[,] xyClicks { get; set; }
        public abstract int Bombs { get; set; }
        public abstract void setBombs();


        public abstract int GetSize();
        public abstract void SetBombsToBoard();

        public abstract int[,] ClickedXY();

        public abstract void setSize();

    }
}
