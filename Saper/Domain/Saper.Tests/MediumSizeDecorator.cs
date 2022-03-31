namespace Saper.Domain.Saper.Tests
{
    internal class MediumSizeDecorator : GameBoardDecorator
    {
        public MediumSizeDecorator(AbstractGameBoard gameBoard) : base(gameBoard) {
            this.Board = new int[20, 20];
        }
        public override int[,] Board { get; set; }
        public override int GetSize() {
            return base.GetSize();
        }
    }
}