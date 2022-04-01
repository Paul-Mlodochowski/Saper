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
       public void ShouldCheckIfTablesAreAtRightSizeSmalll() {



            _gameBoard = new SmallSizeDecorator(_gameBoard);
            Assert.Equal(_gameBoard.GetSize(), 100);
            


        }
        [Fact]
        public void ShouldCheckIfTablesAreAtRightSizeMedium() {

            _gameBoard = new MediumSizeDecorator(_gameBoard);
            Assert.Equal(_gameBoard.GetSize(), 400);


        }
        [Fact]
        public void NumberOfBombsShouldBeEqual() {

            _gameBoard = new SmallSizeDecorator(_gameBoard);
            _gameBoard = new SmallAmountOfBombsDecorator(_gameBoard,_gameBoard.Board);

            Assert.Equal(_gameBoard.Bombs, 15);
            _gameBoard = new MediumAmountOfBombsDecorator(_gameBoard, _gameBoard.Board);
            Assert.Equal(_gameBoard.Bombs, 30);



        }
    }
}
