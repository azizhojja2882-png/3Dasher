3дешер — Unity project scaffold (FULL SCAFFOLD ZIP)

ВНИМАНИЕ:
Этот архив содержит **полный код и структуру** Unity-проекта: скрипты, структуру папок, placeholders сцен и инструкции.
Однако **.unity сцены, материалы и бинарные ассеты не генерируются автоматически** здесь. 
Чтобы получить рабочую сборку .apk, открой этот проект в Unity Editor (2021.3 LTS или 2022.3 LTS), 
создайте сцены на основе README (или импортируйте ваш собственный контент), затем соберите APK/AAB локально или через Unity Cloud Build.

Что внутри:
- Assets/Scripts/ — все основные C#-скрипты (PlayerController, Spawner, Shop, UI, etc.)
- Assets/Scenes/ — placeholder-файлы (.txt) с описанием сцен, которые нужно создать в Unity:
    - Splash (заставка by AzStudio)
    - MainMenu
    - Level_01 ... Level_20
    - Infinite
- Assets/Resources/skins/ — папка для встроенных скинов
- ProjectSettings/ — место для Unity project settings (оставлено пустым для безопасности)

Как собрать:
1) Скачай и распакуй 3дешер.zip в удобное место.
2) Открой Unity Hub, нажми 'Add' и выбери папку распакованного проекта.
3) Открой Unity Editor той же версии, что указана в Project Version (рекомендуется 2021.3 или 2022.3).
4) Создай сцены: в Assets/Scenes/ создай пустые сцены и назови их: Splash, MainMenu, Level_01 ... Level_20, Infinite.
   Для каждой сцены добавь нужные GameObjects и компоненты согласно README ниже.
5) Перенеси скрипты из Assets/Scripts/ на соответствующие GameObjects (Player, Spawner, UIManager и т.д.).
6) Настрой Player prefab: CharacterController, MeshRenderer (куб), PlayerController script.
7) Настрой Spawner: назначь prefab'ы врагов, монет и препятствий.
8) Подключи NativeGallery если хочешь разрешить загрузку пользовательских скинов.
9) Build Settings -> Android -> Switch Platform -> Build (или загрузить ZIP на Unity Cloud Build).

Ограничения этого архива:
- НЕ содержит готовые .unity сцены и бинарные ассеты (модели, текстуры, аудио).
- Не содержит подготовленного keystore.
- Требует Unity Editor для финальной сборки.

Если хочешь, я могу:
- Сгенерировать минимальные .unity сцены в текстовом YAML-формате (ограниченно) — но лучше делать сцены в Unity.
- Подготовить GitHub repo с этим scaffold и готовым GitHub Actions workflow для облачной сборки.
- Добавить дополнительные скрипты: ads, analytics, in-app purchases.

Инструкция по быстрому созданию сцен (что добавить в каждую):
- Splash: Canvas + TextMeshProUGUI "by AzStudio", SplashController.
- MainMenu: Canvas с кнопками Play (Levels), Infinite, Shop, Settings, Exit; UIManager.
- Level scenes: Ground (tag Ground), Player prefab at start position, Spawner, LevelThemeManager with assigned theme.
- Infinite: same as level but LevelManager set to infinite mode.

Удачи! Если хочешь — я прямо сейчас добавлю GitHub Actions workflow и создаю архив 3дешер.zip.