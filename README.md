# JInstaller
Welcome to JInstaller. This is simply a libary to  chain together instructions for moving files. This libary is compatable for both windows and linux.
# Features
- [x] Add File
- [x] Add Directory
- [x] Update File
- [x] Update Directory
- [x] Remove File
- [x] Remove Directory
- [ ] Compress File
- [ ] Compress Directory
- [ ] Decompress File
- [ ] Decompress Directory
- [ ] Azure Download
- [ ] Azure Upload

# Samples
<b>Add Directory</b>
```
Queue<InstallEvent> queue = new Queue<InstallEvent>();
  
queue.Enqueue(new InstallEvent()
{
    InstallType = InstallType.AddDirectory,
    ExtractDirectory = "",
    FilesDirectory = ""
});
  
await installer.RunAsync();
```
<b>Add File</b>
```
Queue<InstallEvent> queue = new Queue<InstallEvent>();
  
queue.Enqueue(new InstallEvent()
{
    InstallType = InstallType.File,
    ExtractDirectory = "",
    FilesDirectory = ""
});
  
await installer.RunAsync();
```
<b>Update Directory</b>
```
Queue<InstallEvent> queue = new Queue<InstallEvent>();
  
queue.Enqueue(new InstallEvent()
{
    InstallType = InstallType.UpdateDirectory,
    ExtractDirectory = "",
    FilesDirectory = ""
});
  
await installer.RunAsync();
```

<b>Update File</b>
```
Queue<InstallEvent> queue = new Queue<InstallEvent>();
  
queue.Enqueue(new InstallEvent()
{
    InstallType = InstallType.UpdateFile,
    ExtractDirectory = "",
    FilesDirectory = ""
});
  
await installer.RunAsync();
```
<b>Remove Directory</b>
```
Queue<InstallEvent> queue = new Queue<InstallEvent>();
  
queue.Enqueue(new InstallEvent()
{
    InstallType = InstallType.RemoveDirectory,
    ExtractDirectory = "",
    FilesDirectory = ""
});
  
await installer.RunAsync();
```

<b>Remove File</b>
```
Queue<InstallEvent> queue = new Queue<InstallEvent>();
  
queue.Enqueue(new InstallEvent()
{
    InstallType = InstallType.RemoveFile,
    ExtractDirectory = "",
    FilesDirectory = ""
});
  
await installer.RunAsync();
```
# Contributions
If you would like a new feature please just branch off and inheiret the IProcessor in the processor folder.
