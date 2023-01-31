namespace LinkedListFifthElementExtractor.App
{
    public class LinkedListTest
    {
        [Fact]
        public void ShouldReturnFifthElement()
        {
            //Arrange
            LinkedList _testLinkedList = new LinkedList();       
            int _testResults = 0;
            int _expectedResults = 7;
            
            // Create a dummy linked list
            _testLinkedList.AddNodeToFront(1);
            _testLinkedList.AddNodeToFront(2);
            _testLinkedList.AddNodeToFront(3);
            _testLinkedList.AddNodeToFront(4);
            _testLinkedList.AddNodeToFront(5);
            _testLinkedList.AddNodeToFront(6);
            _testLinkedList.AddNodeToFront(7);
            _testLinkedList.AddNodeToFront(8); 
            _testLinkedList.AddNodeToFront(9);
            _testLinkedList.AddNodeToFront(10);
            _testLinkedList.AddNodeToFront(11);

            //Act
            _testResults = _testLinkedList.ExtractNode();


            //Assert
            Assert.Equal(_expectedResults, _testResults);

        }

        [Fact]
        public void ShouldReturnTheCorrectNodeCount()
        {
            //Arrange
            LinkedList _linkedList = new LinkedList();
            int _nodeCount = 0;
            int _expectedNodeCount = 5;

            //Act
            _linkedList.AddNodeToFront(1);
            _linkedList.AddNodeToFront(2);
            _linkedList.AddNodeToFront(3);
            _linkedList.AddNodeToFront(4);
            _linkedList.AddNodeToFront(5);
            _nodeCount = _linkedList.count;

            //Assert
            Assert.Equal(_expectedNodeCount, _nodeCount);
        }

    }
}
