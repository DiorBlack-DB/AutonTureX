# AutonTureX

# TranslateAPI
```
public static String Translate(String fromLang, String toLangn, String word)
{
      var toLanguage = toLangn;
      var fromLanguage = fromLang;
      var url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl={fromLanguage}&tl={toLanguage}&dt=t&q={HttpUtility.UrlEncode(word)}";
      var webClient = new WebClient
      {
          Encoding = System.Text.Encoding.UTF8
      };
      var result = webClient.DownloadString(url);
      try
      {
          result = result.Substring(4, result.IndexOf("\"", 4, StringComparison.Ordinal) - 4);
          return result;
      }
      catch
      {
          return "Error";
      }      
}
public static List<String> language = new List<string>(6)
{
        "ru", "en", "zh", "fr", "es", "ar", "aut"
        };
        public static String fromLang = language[1];
        public static String toLang = language[0];
 }
 ```
 
 # Custom WrapPanel Binding & Scrolling
 ```
 <ScrollViewer>
        <ItemsControl  x:Name="itemsControl">
                <ItemsControl.ItemsPanel>
                    <ItemsPanelTemplate>
                        <WrapPanel Orientation="Horizontal"/>
                    </ItemsPanelTemplate>
                </ItemsControl.ItemsPanel>
                <ItemsControl.ItemTemplate>
                    <DataTemplate>
                        <material:Card Margin="{Binding Margin}"> //
                            <Grid>
                                <Grid.RowDefinitions>
                                    <RowDefinition Height="{Binding Height}"/> //150
                                    <RowDefinition Height="Binding Height}"/> //60
                                </Grid.RowDefinitions>
                                <StackPanel Grid.Row="1">
                                    <TextBlock Text="{Binding Text}"/>
                                    <TextBlock Text="{Binding Text1}"/>
                                </StackPanel>
                                <Image Source="{Binding Image}" Grid.Row="0"/>
                            </Grid>
                        </material:Card>
                    </DataTemplate>
                </ItemsControl.ItemTemplate>
            </ItemsControl>
<ScrollViewer>
 ```
