# Аттестация
## Решение
1. Пользователь вводит данные через пробел. Всё сохраняется в одной переменной. 
2. Введённые данные записываются в массив используя пробел, в качестве разделителя.
3. Функция (LenAr) определяет количество элементов соответсвующих условию. Результатом функции является число элементов, которое необходимо хранить в новом массиве.
4. Функция (CorrectArray) заполняет новый массив элементами, соответсвующими условию. Перебор элементов старого массива (array) идёт через цикл (for) и счётчик (j), который используется в качестве значения индекса элемента старого (array) массива. Индексом элемента нового массива (Corarr) является (k). Если элемент массива ( arra[j] ) содержит 3 или меньше символов, то он добавляется в нолвый массив ( Corarr[k] ) после чего счётчик (k) увеличивается на 1. Цикл повторяется до тех пор, пока не будет перебран весь старый массив (array)