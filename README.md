Описание работы кода в Program.cs:

//Ввод массива строк с клавиатуры:

Первым делом я написал код для того, что бы пользователь мог заполнить массив "inputArray", введя через запятую - символы, слова, числа. 
Запятая в данном случае делит введеное пользователем значение на элементы массива. 

//Формирование нового массива "newArray" из строк массива "inputArray" длиной <= 3 символов: 

Создание нового массива "newArray" длинной массива "inputArray".
Создание новой переменной "count" с значением "0" является индексом элементов массива "newArray".
В цикле foreach проверяем каждый элемент массива "inputArray" на равенство "<= 3".
Если элемент соответсвует равенству, то записывается в массив "newArray" под индексом равному значению "count", и значение "count" прибавляется 1.

//Вывод нового массива на экран:

В цикле for каждый элемент массива "newArray" выводится на экран по очереди.
