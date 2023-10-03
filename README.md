# Контрольная работа 1 четверть

**Задача:** 

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

*Примеры*:

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

[“1234”, “1567”, “-2”, “computer science”] → [“-2”]

[“Russia”, “Denmark”, “Kazan”] → []

**Решение**:
1. Пользователь вводит количество элеменов в массиве N, а затем по очереди вводит элементы массива strings. Заполнение массива выносим в отдельный метод
2. Дополнительно создаем массив result, в котороый будем помещать результат работы программы, который будем выводить, размер массива задаем значением N. Задаем стартовый индекс indexResult для данного массива равный 0.
3. В цикле for походимся по каждому элементу массива strings (в отдельном методе):
 * Если длина элемента массива strings меньше или равна 3,то мы данный элемент записываем в массив result индекс indexResult увеличивам на 1.
 * Если длина элемента массива stings больше 3, то мы идем к следующему элементу в массиве strings
4. Когда мы прошли все элементы массива strings мы выводим на экран массив result. Вывод массива в консоль выносим в отдельный метод.