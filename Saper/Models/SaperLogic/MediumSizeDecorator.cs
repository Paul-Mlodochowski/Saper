namespace Saper.Models.SaperLogic
{
    public class MediumSizeDecorator : GameBoardDecorator
    {
        public MediumSizeDecorator(AbstractGameBoard gameBoard) : base(gameBoard) {
            this.Board = new int[20, 20];
            this.xyClicks = new int[20, 20];
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