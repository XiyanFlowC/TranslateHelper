# TranslateHelper
A translate helper witch has a little expendability. The UI &amp; comments language is Chinese.

## 用途
期望能够简化各类文本翻译辅助工具的开发周期——专注于文件格式而非各类UI的控制。所以期望将所有控制流程都分离出来。利用WebBrowser进行预览渲染。现在仍有一些不足……主要是外部文件引用的的问题——利用DocumentText渲染时会使URI失效。现仍无有效解决方案。

## 内附插件
目前主要为Ar tonelico的对话导出和菜鸟格式的文本导出提供支持。

### Ar tonelico对话导出
从AT的.evd文件中抽出的对话，具有以下格式：

<id>,<narrator id>,<text>

<selection text>

### 菜鸟格式的文本导出
菜鸟小生所开发的导出器所使用的常用文本格式：

<address>,<length>,<text>
