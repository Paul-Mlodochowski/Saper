namespace Saper.Models.SaperLogic
{
    public class MediumSizeDecorator : GameBoardDecorator
    {
        public MediumSizeDecorator(AbstractGameBoard gameBoard) : base(gameBoard) {
            Board = new int[20, 20];
        }
        public override int[,] Board { get; set; }
        public override int GetSize() {
            return base.GetSize();
        }
    }
}