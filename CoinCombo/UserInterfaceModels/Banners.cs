namespace CoinCombo.UserInterfaceModels
{
  class WelcomeBanner
  {
    public static string Welcome { get; } = @"
    __   ___  ____  ____          __   ___   __ __  ____   ______    ___  ____  
   /  ] /   \l    j|    \        /  ] /   \ |  T  T|    \ |      T  /  _]|    \ 
  /  / Y     Y|  T |  _  Y      /  / Y     Y|  |  ||  _  Y|      | /  [_ |  D  )
 /  /  |  O  ||  | |  |  |     /  /  |  O  ||  |  ||  |  |l_j  l_jY    _]|    / 
/   \_ |     ||  | |  |  |    /   \_ |     ||  :  ||  |  |  |  |  |   [_ |    \ 
\     |l     !j  l |  |  |    \     |l     !l     ||  |  |  |  |  |     T|  .  Y
 \____j \___/|____jl__j__j     \____j \___/  \__,_jl__j__j  l__j  l_____jl__j\_j
                                                                                ";
  }

  class GoodbyeBanner
  {
    public static string Goodbye { get; } = @"
    ____   ___    ___   ___    ____   __ __    ___ 
  /    T /   \  /   \ |   \  |    \ |  T  T  /  _]
Y   __jY     YY     Y|    \ |  o  )|  |  | /  [_ 
|  T  ||  O  ||  O  ||  D  Y|     T|  ~  |Y    _]
|  l_ ||     ||     ||     ||  O  |l___, ||   [_ 
|     |l     !l     !|     ||     ||     !|     T
l___,_j \___/  \___/ l_____jl_____jl____/ l_____j
                                                 ";
  }
}
