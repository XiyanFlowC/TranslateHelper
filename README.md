# TranslateHelper
A translate helper witch has a little expendability. The UI &amp; comments language is Chinese.

## 用途
期望能够简化各类文本翻译辅助工具的开发周期——专注于文件格式而非各类UI的控制。所以期望将所有控制流程都分离出来。利用WebBrowser进行预览渲染。现在仍有一些不足……主要是外部文件引用的的问题——利用DocumentText渲染时会使URI失效。现仍无有效解决方案。

## 内附插件
目前主要为Ar tonelico的对话导出和菜鸟格式的文本导出提供支持。

要使之工作，需要将bin\\Plugins复制到输出目录中。

### Ar tonelico对话导出
要使之工作，输出目录需要含有narrator.txt。

从AT的.evd文件中抽出的对话，具有以下格式：

\<id\>,\<narrator id\>,\<text\>

\<selection text\>

### 菜鸟格式的文本导出
菜鸟小生所开发的导出器所使用的常用文本格式：

\<address\>,\<length\>,\<text\>

-----

## Usage
To simplify workflow when make translating tools.

## Plugins
Provides parsing ability for \*.evd extract text from Ar tonelico and standard addressed text.

To make it work, copy bin\\Plugins to output fold。

### Ar tonelico dialogue extraction
To make it work, narrator.txt should exists in output fold。

The extraction format：

\<id\>,\<narrator id\>,\<text\>

\<selection text\>

### Standard addressed text
Format：

\<address\>,\<length\>,\<text\>
