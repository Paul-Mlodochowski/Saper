namespace Saper.Models.SaperLogic
{
    public class SmallSizeDecorator : GameBoardDecorator
    {
        private const int SIZE = 10;

        public SmallSizeDecorator(AbstractGameBoard gameBoard) : base(gameBoard) {
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
    }
}
