namespace Saper.Domain.Saper.Tests
{
    public class SmallSizeDecorator : GameBoardDecorator
    {
        public SmallSizeDecorator(AbstractGameBoard gameBoard) : base(gameBoard) {
            this.Board = new int[10, 10];
        }
        
        public override int[,] Board { get; set; }
        public override int GetSize() {
            return base.GetSize();
        }
    }
}
