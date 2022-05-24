# Техническое задание по VFX

### Требования
- Unity 2020.3.3f
- Visual Effects Library

Требуется скачать видеофайлы по [ссылке](https://disk.yandex.ru/d/4Q3hKF_T7hVGNw)
Объёмное видео требуется расположить по пути
`AppData\LocalLow\new-reality\StreamerClient\CloudsBinary`

### Инструкция
В проекте имеется BaseVFX, который отвечает за базовую визуализацию облака.

Для проигрывания видео на сцене `VoluSample.unity` есть объект `CloudPlayer` с дочерними объектами `Viewer` и `Audio`. Компонент Visual Effect расположен на объекте `Viewer`.
Дла запуска проигрывания облака точек требуется:
- Убедиться, что в `CloudPlayer` указано `Path_Video` (Название папки с видео, например, `2021.12.8_Oleg_Head`)
- Нажать на кнопку `Init` на компоненте `CloudPlayer` (На объекте viewer должен сгенерироваться корректный путь до объемного видео в `Full_Path` и подтянуться файлы в `Files`). Видео должно запуститься автоматически.
- При изменении каких-либо параметров следует остановить проигрывание, требуется нажать Stop, затем в соответствующем порядке кнопки `ClearManager`, `Dispose`, и после возобновить проигрывание, нажав `Init`.

### Задание 
Разработать VFX появления облака точек с красивым оформлением. Референсы подобрать самостоятельно.



# Test task for VFX designer job opening

### Software requirements:
- Unity 2020.3.3f
- Visual Effects Library

You need to download video files under the [link](https://disk.yandex.ru/d/4Q3hKF_T7hVGNw)
The volumetric video should be placed along the path `AppData\LocalLow\new-reality\StreamerClient\CloudsBinary`

### Instruction
The project has BaseVFX which provides basic visualization of point cloud. GameObject `CloudPlayer` together with sub-gameobjects `Viewer` and `Audio` are used play a video in a scene `VoluSample.unity`. Visual Effect component is located in the `Viewer`. To launch point cloud playback you should:
-	Make sure that CloudPlayer has `Path_Video` (a name of a folder with video, i.e. `2021.12.8_Oleg_Head`)
-	Click `Init` button in `CloudPlayer` (viewer object should generate correct path to volumetric video in `Full_Path`, then files will emerge in the `Files` folder). Video playback should start automatically. 
-	If any parameters change you should stop playback: click `Stop`, then `ClearManager` and `Dispose`. After that resume playback by clicking `Init`.

### Task
Design a beautiful VFX for point cloud. Chose references yourself.
