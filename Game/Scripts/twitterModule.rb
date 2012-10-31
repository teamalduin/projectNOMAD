require 'rubygems'
require 'twitter'

module TwitterModule
  
  def getInfo (file, lineNumber)
    lineNumber.times{file.gets}
    line = $_
    length=line.length
    
    i = 0
    while line[i] != ':' do
       i+=1
    end
    i+=1
 
    levelString=""
    while line[i]!="\n" do
      levelString+=line[i]
      i+=1
    end

    file.rewind
    return levelString

  end
  
  def setUserInfo()
    Twitter.configure do |config|
      
      config.consumer_key = 'z8cEBGS36HlKPtP4khng'
      config.consumer_secret = 'uwBGr985dWruquUKFr3UImiz5jQKXrhcbNSr0XSk'
      config.oauth_token = '594267789-FHaKoXryjlffk5X4w1nnM8X81UxlNwEJRXbbQlZX'
      config.oauth_token_secret = '5oWHdHOqMpRSkjKC1j5Mwq9bOHEu3dCOn74Axk0'
      
    end
    
  end
  
  def tweet(file, info)
    #Twitter.update("I leveled up on #projectNOMAD, now I'm level "+info+"!")
    file.puts("leveledUp:0")
    p info
  end
  
  def listener

     setUserInfo()
    
     if File.exists?("config.projectNOMAD") then
       configFile = File.open("config.projectNOMAD", "r+")
     else
       File.new("config.projectNOMAD", "w")
       configFile = File.open("config.projectNOMAD", "r+")
     end
     
     while true do
       info = getInfo(configFile, 1)
       
       if info == "1" then
         info2 = getInfo(configFile, 2)
         tweet(configFile, info2)
       end
     end
     
     configfile.close
      
  end
  
end
