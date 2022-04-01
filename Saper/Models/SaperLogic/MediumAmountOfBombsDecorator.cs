
namespace Saper.Models.SaperLogic
{
    public class MediumAmountOfBombsDecorator : GameBoardDecorator
    {
        private const int NUMBEROFBOMBS = 30;

        public MediumAmountOfBombsDecorator(AbstractGameBoard gameBoard, int[,] Board) : base(gameBoard) {
            this.Bombs = NUMBEROFBOMBS;
            this.Board = Board;
            setBombs();
            setSize();
        }
        public override int Bombs { get; set; }
        public override int[,] Board { get; set; }
        public override void setBombs() {
            base.setBombs();
        }
        public override void setSize() {
            base.setSize();
        }
    }
}