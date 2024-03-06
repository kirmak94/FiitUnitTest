1. Перепишите класс UserCreator так, чтобы он зависел от IUserValidator и от IUsersRepository. 
2. Перепешите тесты на UserCreator, замокав вызовы IUserValidator и IUsersRepository. Можете использовать любую мок библиотеку
3. Настроить для тестов UserCreatorTests параллельный прогон внутри класса, а для всех классов в UserValidatorTests параллельный прогон по фикстурам,
 используя аттрибуты из e5_ParallelizationExamples