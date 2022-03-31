using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Saper.Models.SaperLogic
{
    public class SaperLogicTests
    {
        private AbstractGameBoard _gameBoard;
        public SaperLogicTests() {
            _gameBoard = new GameBoard();

        }
        [Fact]
        public void ShouldCheckIfTablesAreNotNull() 
        {
            _gameBoard = new SmallSizeDecorator(_gameBoard);

            Assert.NotNull(_gameBoard.Board);
            
        }
        [Fact]
       public void ShouldCheckIfTablesAreAtRightSize() {

            List<GameBoardDecorator> list = new List<GameBoardDecorator>()
            {
            new SmallSizeDecorator(_gameBoard),
            new MediumSizeDecorator(_gameBoard),
            //new LargeSizeDecorator(_gameBoard)
            };
     

            Assert.Equal((_gameBoard = list.ElementAt(0)).GetSize(), 100);
            Assert.Equal((_gameBoard = list.ElementAt(1)).GetSize(), 400);

        }
    }
}
