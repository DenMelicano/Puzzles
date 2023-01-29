namespace LinkedListFifthElementExtractor.App
{
    public class LinkedListExtractorTest
    {
        [Fact]
        public void ShouldReturnFifthElement()
        {
            //Arrange
            LinkedList _testLinkedList = new LinkedList();
            var requiredCountFromTail = 5;
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
            _testResults = _testLinkedList.ExtractNode(requiredCountFromTail);


            //Assert
            Assert.Equal(_expectedResults, _testResults);

        }
    }
}
