# Лабораторные работы по "Объектно-ориентированному программированию"
Выполнил: Гольцман Глеб 408456 K3244

Проверил: 

[Задания к лабораторным работам и правила](https://backboost-club.notion.site/65c38f38b87041bd885f7f06589939e0)
## Лабораторная работа №1. Система управления учебными курсами и преподавателями

**Вы разрабатываете систему для университета, который хочет улучшить управление своими образовательными программами. Важно, чтобы система была гибкой, расширяемой и легко поддерживаемой.**

Цель ЛР заключается в закреплении навыков работы с наследованием, полиморфизмом, абстракцией и интерфейсами, а также создание объектов и их взаимодействие в системе.

1. Позволять добавлять и удалять курсы, а также назначать преподавателей на эти курсы.
Включать возможность хранения и возможности получения информации о студентах, записанных на каждый курс.
2. Поддерживать различные типы курсов: онлайн-курсы и офлайн-курсы с уникальными характеристиками.
3. Обеспечивать возможность получить все курсы, которые ведет конкретный преподаватель.
4. Ключевая бизнес логика должна быть покрыта юнит тестами. (необходимо использовать xunit)


## Лабораторная работа №2. Управление инвентарем в ролевой игре
Разработайте систему управления инвентарем для ролевой игры. 

**Вы работаете над созданием игры, где важно обеспечить управление инвентарем игрока. Ваша задача — создать такую систему, которая бы поддерживала различные типы предметов и их взаимодействие, включая возможность улучшения экипировки**

Цель ЛР заключается в применение принципов ООП для создания сложной системы с множеством взаимодействующих объектов, где правильный выбор паттернов поможет оптимизировать код.

Система должна:

1. Позволять игрокам добавлять различные типы предметов в инвентарь, такие как оружие, броня, зелья и квестовые предметы.
2. Учитывать уникальные свойства каждого предмета, например, урон для оружия или защиту для брони. 
3. Предоставлять возможность использовать или экипировать предметы, а также отображать информацию о текущем состоянии инвентаря.
4. Обеспечивать возможность комбинирования или улучшения предметов.
5. Логику необходимо покрыть unit тестами
6. CLI не нужен


## Лабораторная работа №3. Управление заказами в службе доставки
Разработайте систему для управления заказами в службе доставки еды.

**Вы разрабатываете систему для стартапа 
в сфере доставки еды, который хочет обеспечить быструю и надежную обработку заказов. Система должна быть масштабируемой, чтобы справляться с растущим числом пользователей**

Система должна:

1. Поддерживать создание и управление заказами, включая возможность выбора блюд из меню.
2. Обрабатывать различные типы заказов, такие как стандартные заказы и заказы с особенными условиями (например, быстрая доставка, персональные предпочтения).
3. Предоставлять возможность отслеживания состояния заказа: подготовка, доставка, выполнен.
4. Включать функции для расчета стоимости заказа с учетом различных факторов, таких как скидки, налоги, плата за доставку.
5. Логику необходимо покрыть unit тестами
6. CLI не нужен


## Лабораторная работа №4. Система управления финансами
Разработайте систему для управления клиентами и их счетами в финансовом приложении.

**Вы работаете над системой для банка, который стремиться упростить управление финансовыми операциями. Система должна быть надежной.**

Цель ЛР заключается в применении принципов ООП и паттернов проектирования для создания безопасной, масштабируемой и легко поддерживаемой системы управления клиентами и финансовыми данными.

Система должна:

1. Поддерживать создание и управление клиентами, включая добавление различных типов счетов (например, текущий, депозитный, инвестиционный).
2. Обеспечивать возможность перевода средств между счетами, начисления процентов и ведения учета операций.
3. Включать функции для генерации отчетов по состоянию счета, истории операций и общей статистики по клиентам.
4. Поддерживать разные валюты (как минимум, рубль, юань, доллар) и получать актуальный курс из внешней системы. Например, из API ЦБ РФ.   
5. Логику необходимо покрыть unit тестами
6. За реализацию интеграционных тестов будут начислены дополнительные баллы 

 
