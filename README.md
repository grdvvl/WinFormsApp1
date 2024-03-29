Лабораторная работа 8
======================
тема: "Рисование фигру"
------------------------
### Задание: рисование заданных фигур при нажатии на кнопку

#### Вариант 2

**Дано**

1. Фигуры. 
   1. Четверть круга
   2. Эллипс
2. Цвета.
   1. Белый
   2. Зеленый

**Определим отношение цвета к фигуре**

|  фигура  |  цвет   |
|:--------:|:-------:|
| четверть |  белый  |
|  эллипс  | зеленый |

Для начала создадим кисть, которой будем рисовать и сразу присвоем эй белый цвет: `brush = Brushes.White;`

Теперь создадим объект график: `Graphics gr = this.CreateGraphics();`

Итак, теперь мы можем перейти к нашему рисованию! Для начала изобразим желтый эллипс `gr.FillPie(brush, 0, 0, 100, 100, -90, 90);`

![image](https://user-images.githubusercontent.com/118161199/222415363-438af73b-b69e-48a0-8690-6b9751c65553.png)

Поменяем звет на зеленый для следующей фигуры: `brush = Brushes.Green`

Зададим для эллипса необходимые параметры: `gr.FillEllipse(brush, 20, 50, 100, 50);`

![image](https://user-images.githubusercontent.com/118161199/222415617-aabb164d-c174-4e47-8d3c-ed150f161bf4.png)

В итоге, на нашем экране будет следующая картинка:

![image](https://user-images.githubusercontent.com/118161199/222415693-71602a01-5c94-4454-a964-b881de7053d0.png)

#### Контакты
**Почта:** <grdvvl241100@gmail.com>
