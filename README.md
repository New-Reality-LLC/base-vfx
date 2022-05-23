# Техническое задание по VFX

### Требования
- Unity 2020.3.3f
- Visual Effects Library

Требуется скачать видеофайлы по [ссылке1](https://disk.yandex.ru/d/e1LOa3rzmiyDUQ) и [ссылке2](https://disk.yandex.ru/d/845CF_-AsbSr7w).
Объёмное видео требуется расположить по пути
`AppData\LocalLow\new-reality\StreamerClient\CloudsBinary`

### Инструкция
В проекте имеется BaseVFX, который отвечает за базовую визуализацию облака.

Для проигрывания видео на сцене `VoluSample.unity` есть объект CloudPlayer с дочерними объектами Viewer и Audio. Компонент Visual Effect расположен на объекте Viewer.
Дла запуска проигрывания облака точек требуется:
- Убедиться, что в CloudPlayer указано Path_Video (название папки с видео, например, `vfx_19_ArchivedBin`)
- Нажать на кнопку Init на компоненте CloudPlayer (на объекте viewer должен сгенерироваться корректный путь до объемного видео в Full_Path и подтянуться файлы в Files). Видео должно запуститься автоматически.
- При изменении каких-либо параметров следует остановить проигрывание, требуется нажать Stop, затем в соответствующем порядке кнопки ClearManager, Dispose, и после - возобновить проигрывание, нажав Init.


### Задание 
Требуется улучшить визуально качество видео. Скрины с примерами по [ссылке](https://disk.yandex.ru/d/AqWMROfF70C1yw)