# Base project for VFX test

### Требования
- Unity 2020.3.3f
- Visual Effects Library

Требуется скачать видеофайлы по [ссылке](https://disk.yandex.ru/d/4Q3hKF_T7hVGNw)
Объёмное видео требуется расположить по пути
`AppData\LocalLow\new-reality\StreamerClient\CloudsBinary`

### Инструкция
В проекте имеется 2 VFX: базовый VFXOrigin и Hologram.
Базовый требуется для простой визуализации самого облака.

Для проигрывания видео на сцене SampleScene.unity есть объект CloudPlayer с дочерними объектами Viewer и Audio. Компонент Visual Effect расположен на объекте Viewer.
Дла запуска проигрывания облака точек требуется:
- Убедиться, что в CloudPlayer указано Path_Video (Название папки с видео, например, 2021.12.8_Oleg_Head)
- Нажать на кнопку Init на компоненте CloudPlayer (На объекте viewer должен сгенерироваться корректный путь до объемного видео в Full_Path и подтянуться файлы в Files). Видео должно запуститься автоматически.
- При изменении каких-либо параметров следует остановить проигрывание, требуется нажать Stop, затем в соответствующем порядке кнопки ClearManager, Dispose, и после возобновить проигрывание, нажав Init.


### Задание 
Оптимизировать VFX [Hologram](https://github.com/New-Reality-LLC/base-vfx/blob/main/Assets/Viewer/VFX/Hologram.vfx).
При запущенном приложении и включенными всеми параметрами в Stats пишет 1.2M Verts и Tris.
