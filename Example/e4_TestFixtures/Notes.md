## Атрибуты для сборки-разборки окружения 

### [SetUp]
- Выполняет сборку окружения. Выполняется перед каждым тестом


### [TearDown]
- Выполняет разборку окружения. Выполняется после каждого теста

### [OneTimeSetUp]
- Выполняет сборку окружения. Выполняется один раз перед всеми тестами внутри TestFixture

### [OneTimeTearDown]
- Выполняет разборку окружения. Выполняется после каждого теста


### SetUpFixture
- Атрибут класса содержащего по одному статическому методу [OneTimeSetUp] и/или [OneTimeTearDown]
- Методы из класса будут вызваны 1 раз перед всеми тестами в пространстве имен