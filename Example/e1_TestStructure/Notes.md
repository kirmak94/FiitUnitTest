## Нейминг

#### Варианты структуры
- SystemUnderTest_StateUnderTest_ExpectedBehavior
- SystemUnderTest_ExpectedBehavior_StateUnderTest
- SystemUnderTest_Should_ExpectedBehavior_When_StateUnderTest
- SystemUnderTest_WithStateUnderTest_ShouldExpectedBehavior


### Преимущества хорошего нейминга 
- Список Названий тестов может служить нам документацией по методу
- Посмотрев на набор тестов, можно определить ожидаемое поведение метода, не глядя на его код
- Если тест не пройден, сразу можно увидеть, какие сценарии не соответствуют ожиданиям.
- Можем найти тест на конкретный сценарий полнотекстовым поиском, если изменилась функциональность и тесты нужно исправить или дописать


## Структура AAA (Arrange-Act-Assert)
### arrange 
- Настройка сервисов
- Создание и подготовка связанных сущностей
- Подготовка данных в бд
- Переход к нужной странице в браузерных тестах
### act 

- Совершение нужных манипуляций
- Вызов методов
- Получение проверяемого результата*


### assert
- Проверка, что фактический результат, который мы получили в блоке Act 
- совпадает с ожидаемым результатом из блока Arrange

