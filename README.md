# Final_assignment_from_the_main_block_GeekBrains

*English*

## Step 1. 
I created a new function, called it
```
string[] FilterArrayWithThreeChars(string[] arr)
``` 

## Step 2.
Inside of the function:

1. I calculated amount of elements, that satisfies the condition (which is 3 characters in the string and less), using `foreach` loop. Within this loop I've set an `if` condition to check each element, I used method `element.Length`. With each element I have increased count to 1 (initially count is set as 0).
2. Next step in the function is to create a new string array and set `int index` equalled to 0. For length of the new array I've taken `count` from the previous `foreach` loop.
```
string[] resultArr = new string[count];
int index = 0;
```
3. Filling in new `resultArr` with the elements, that satisfy the condition of the task. For that I open a new `foreach` loop, where I set a new condition:
```
if (element.Length <= 3>)
{
    resultArr[index] = element;
    index++;
}
```
4. This way we enter all the relevant elements to the new array. And in the end of the function we return resultArr:
```
return resultArr;
```

## Step 3.
In the Main:

1. First we set up the initial string array with some values. In my case I set it up in the code.
2. Then we create a new array, which I called newArray, using function `FilterArrayWithThreeChars`:
```
string[] newArray = FilterArrayWithThreeChars(array);
```
3. And printing out the result, using `Console.WriteLine` and method `string.Join`.






*Русский*

## Шаг 1. 
Я создала функцию с именем:
```
string[] FilterArrayWithThreeChars(string[] arr)
``` 

## Шаг 2.
Внутри этой функции:

1. Я посчитала количество элементов, которое удовлетворяет условию задачи (3 символа и меньше), использую цикл `foreach`. Внутри этого цикла я задала условие `if`, чтобы проверить каждый элемент я использовала метод `element.Length`. С каждым элементом я увеличивала переменную `count` на единицу (изначально переменная `count` была задана как 0).
2. Следующий шаг в функции - создать новый строковый массив и задать переменную `int index` равную 0. Чтобы задать длину нового массива, я использовала переменную `count` из предудыщего цикла  `foreach`.
```
string[] resultArr = new string[count];
int index = 0;
```
3. Заполняем новый массив `resultArr` новыми элементами, которые удовлетворяют условию задачи. Для этого я открыла новый цикл `foreach`, где я добавила новое условие:
```
if (element.Length <= 3>)
{
    resultArr[index] = element;
    index++;
}
```
4. Таким образом мы добавим в новый массив все подходящие элементы. И закроем функцию, возвращая новый массив `resultArr`:
```
return resultArr;
```

## Шаг 3.
В методе Main:

1. Сначала мы задаем оригинальный массив с некоторыми строками. Я просто задала значения сразу в коде, без ввода с консоли.
2. Затем создаем новый массив, который я назвала `newArray`,используя мою функцию `FilterArrayWithThreeChars`:
```
string[] newArray = FilterArrayWithThreeChars(array);
```
3. И в конце печатаем результа, используя `Console.WriteLine` и метод `string.Join`.