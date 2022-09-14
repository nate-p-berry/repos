const firstNum = 42;
const secondNum = 14;

function addNums(firstNum, secondNum) { 
    return firstNum + secondNum; 
}

function subtractNums(firstNum, secondNum) { 
    return firstNum - secondNum; 
}

function multiplyNums(firstNum, secondNum) { 
    return firstNum * secondNum; 
}

function divideNums(firstNum, secondNum) { 
    return firstNum / secondNum; 
}

function printNumResults(firstNum, secondNum) {
    document.write("first we have addition" + addNums(firstNum,secondNum), 
                    "\nthen we have subtraction" + subtractNums(firstNum,secondNum), 
                    "\nafter that we have division" + divideNums(firstNum,secondNum), 
                    "\nand finally multiplication" + multiplyNums(firstNum,secondNum));
}

printNumResults(firstNum, secondNum);