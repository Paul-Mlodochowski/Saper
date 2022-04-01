namespace Saper.Models.SaperLogic
{
    public class MediumSizeDecorator : GameBoardDecorator
    {
        private const int SIZE = 20;

        public MediumSizeDecorator(AbstractGameBoard gameBoard) : base(gameBoard) {
            this.Board = new int[SIZE, SIZE];
            this.xyClicks = new int[SIZE, SIZE];
            setSize();
        }
        public override int[,] Board { get; set; }
        public override int[,] xyClicks { get; set; }
        public override int GetSize() {
            return base.GetSize();
        }
        public override void setSize() {
            base.setSize();
        }
        
        public override void SetBombsToBoard() {

            base.SetBombsToBoard();
        }
    }
}