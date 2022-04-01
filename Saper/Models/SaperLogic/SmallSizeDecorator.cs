namespace Saper.Models.SaperLogic
{
    public class SmallSizeDecorator : GameBoardDecorator
    {
        public SmallSizeDecorator(AbstractGameBoard gameBoard) : base(gameBoard) {
            this.Board = new int[10, 10];
            this.xyClicks = new int[10, 10];
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
    }
}
