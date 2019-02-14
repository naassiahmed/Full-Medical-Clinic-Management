; JAutoExp.Dat - templates for automatically expanding data
; Copyright(c) 1995 Microsoft Corporation. All Rights Reserved.
;---------------------------------------------------------------
;
; While debugging, Data Tips and items in the Watch and Variable
; windows are automatically expanded to show their most important
; elements. The expansion follows the format given by the rules
; in this file. You can add rules for your types or change the
; predefined rules.
;
; For good examples, read the rules in this file.
;
; An AutoExpand rule is a line with the name of a type, an equals
; sign, and text with replaceable parts in angle brackets. The
; part in angle brackets names a member of the type and an
; optional Watch format specifier.
;
; AutoExpand rules use the following syntax. The equals sign (=),
; angle brackets (<>), and comma are taken literally. Square
; brackets ([]) indicate optional items.
;
; type=[text]<member[,format]>...
;
; type      Name of the type.
;
; text      Any text.  Usually the name of the member to display,
;           or a shorthand name for the member.
;
; member    Name of a member to display.
;
; format    Watch format specifier. One of the following:
;
;   Letter  Description                 Sample         Display
;   ------  --------------------------  ------------   -------------
;   d,i     Signed decimal integer      0xF000F065,d   -268373915
;   u       Unsigned decimal integer    0x0065,u       101
;   o       Unsigned octal integer      0xF065,o       0170145
;   x,X     Hexadecimal integer         61541,X        0X0000F065
;   l,h     long or short prefix for    00406042,hx    0x0c22
;             d, i, u, o, x, X
;   f       Signed floating-point       3./2.,f        1.500000
;   e       Signed scientific-notation  3./2.,e        1.500000e+000
;   g       Shorter of e and f          3./2.,g        1.5
;
; If there is no rule for a class, the base classes are checked for
; a matching rule.
;
;---------------------------------------------------------------
[AutoExpand]

; java.lang.*
java.lang.Boolean =<value>
java.lang.Character =<value>
java.lang.Double =<value>
java.lang.Float =<value>
java.lang.Integer =<value>
java.lang.Long =<value>
java.lang.String =<value>
java.lang.StringBuffer =value=<value>

java.lang.Throwable =detailMessage=<detailMessage>
java.lang.Thread =name=<name>
java.lang.ThreadGroup =name=<name>
java.lang.Win32Process =handle=<handle>

; java.util.*
java.util.Date =value=<value>
java.util.Hashtable =count=<count>, threshold=<threshold>, loadFactor=<loadFactor>
java.util.HashtableEntry =hash=<hash>, key=<key>, value=<value>
java.util.HashtableEnumerator =index=<index>
java.util.Random =seed=<seed>
java.util.StringTokenizer =currentPosition=<currentPosition>, str=<str>
java.util.Vector =elementCount=<elementCount>, capacityIncrement=<capacityIncrement>
java.util.VectorEnumerator =count=<count>, vector=<vector>

; java.io.*
java.io.BufferedInputStream =count=<count>, pos=<pos>, marklimit=<marklimit>, markpos=<markpos>
java.io.BufferedOutputStream =count=<count>
java.io.ByteArrayInputStream =count=<count>, pos=<pos>
java.io.ByteArrayOutputStream =count=<count>
java.io.DataOutputStream =written=<written>
java.io.DataOutputStream =written=<written>
java.io.File =path=<path>
java.io.FileDescriptor =fd=<fd>
java.io.FileInputStream =fd=<fd>
java.io.FileOutputStream =fd=<fd>
java.io.InterruptedIOException =bytesTransferred=<bytesTransferred>
java.io.LineNumberInputStream =lineNumber=<lineNumber>, markLineNumber=<markLineNumber>, pushBack=<pushBack>
java.io.PipedInputStream =closed=<closed>, in=<in>, out=<out>, readSide=<readSide>, writeSide=<writeSide>
java.io.PipedOutputStream =sink=<sink>
java.io.PrintStream =autoFlush=<autoFlush>, trouble=<trouble>
java.io.PushbackInputStream =pushBack=<pushBack>
java.io.RandomAccessFile =fd=<fd>
java.io.SrtingBufferInputStream =count=<count>, pos=<pos>

; java.net.*
java.net.DatagramPacket =address=<address>, length=<length>, port=<port>
java.net.DatagramSocket =fd=<fd>, localPort=<localPort>
java.net.InetAddress =address=<address>, family=<family>, hostName=<hostName>
java.net.ServerSocket =<impl>
java.net.Socket =<impl>
java.net.SocketImpl =fd=<fd>, address=<address>, port=<port>, localPort=<localPort>
java.net.SocketInputStream =eof=<eof>, <impl>
java.net.SocketOutputStream =<impl>
java.net.URL =protocol=<protocol>, host=<host>, port=<port>, file=<file>, ref=<ref>
java.net.URLConnection =connected=<connected>, url=<url>, doInput=<doInput>, doOutput=<doOutput>, allowUserInteraction=<allowUserInteraction>, useCaches=<useCaches>

; java.awt.*
java.awt.BorderLayout =hgap=<hgap>, vgap=<vgap>
java.awt.Button =label=<label>
java.awt.CardLayout =hgap=<hgap>, vgap=<vgap>
java.awt.CheckBox =label=<label>, state=<state>
java.awt.CheckBoxGroup =currentChoice=<currentChoice>
java.awt.CheckBoxMenuItem =state=<state>
java.awt.Choice =selectedIndex=<selectedIndex>
java.awt.Color =value=<value>
java.awt.Component =x=<x>, y=<y>, width=<width>, height=<height>, visible=<visible>, enabled=<enabled>, valid=<valid>
;java.awt.Container =ncomponents=<ncomponents>, <super>
java.awt.Container =ncomponents=<ncomponents>
;java.awt.Dialog =resizable=<resizable>, modal=<modal>, title=<title>, <super>
java.awt.Dialog =resizable=<resizable>, modal=<modal>, title=<title>
java.awt.Dimension =width=<width>, height=<height>
java.awt.FocusManager =focusRoot=<focusRoot>, focusOwner=<focusOwner>
;java.awt.Frame =title=<title>, resizable=<resizable>, <super>
java.awt.Frame =title=<title>, resizable=<resizable>
java.awt.GridBahConstraints =gridx=<gridx>, gridy=<gridy>, gridwidth=<gridwidth>, gridheight=<gridheight>, weightx=<weightx>, weighty=<weighty>
java.awt.GridBagLayout =defaultConstraints=<defaultConstraints>, layoutInfo=<layoutInfo>
java.awt.GridBagInfo =width=<width>, height=<height>, startx=<startx>, starty=<starty>
java.awt.GridLayout =hgap=<hgap>, vgap=<vgap>, rows=<rows>, cols=<cols>
java.awt.Insets =top=<top>, left=<left>, bottom=<bottom>, right=<right>
java.awt.Label =label=<label>, alignment=<alignment>
;java.awt.List =rows=<rows>, multipleSelections=<multipleSelections>, <super>
java.awt.List =rows=<rows>, multipleSelections=<multipleSelections>
java.awt.MenuItem =label=<label>, enabled=<enabled>
;java.awt.MenuBar =tearOff=<tearOff>, isHelpMenu=<isHelpMenu>, <super>
java.awt.MenuBar =tearOff=<tearOff>, isHelpMenu=<isHelpMenu>
