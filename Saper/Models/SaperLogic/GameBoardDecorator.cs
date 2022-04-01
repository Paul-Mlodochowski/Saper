namespace Saper.Models.SaperLogic
{
    public abstract class GameBoardDecorator : AbstractGameBoard
    {
        protected AbstractGameBoard _gameBoard;
        
        public override int[,] Board { get; set; }
        
        public override int Bombs { get; set; }
        public override int[,] xyClicks { get; set; }

        public GameBoardDecorator(AbstractGameBoard gameBoard) {
            _gameBoard = gameBoard;
        }
        

        public override int GetSize() {
            
            return _gameBoard.GetSize();
        }
        public override void SetBombsToBoard() {
            _gameBoard.Bombs = Bombs;
            _gameBoard.SetBombsToBoard();
        }
        public override int[,] ClickedXY() {
         
            
            return _gameBoard.ClickedXY();
        }
        public override void setSize() {
            _gameBoard.Board = this.Board;
            _gameBoard.xyClicks = this.xyClicks;
        }
        public override void setBombs() {
            _gameBoard.Bombs = Bombs;
        }
    }
}
