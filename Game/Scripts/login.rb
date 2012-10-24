require_relative 'User.rb'
require 'mongo'
require 'mongo_mapper'
MongoMapper.database="users"



def login
  username = ARGV[0]
  password = ARGV[1]
  if User.find_by_username(:username =>"saulo")==nil
    return 0
  else
     if User.find_by_username(:username =>"saulo").password != password
       return 0
      
     else
       return 1
     end
  end
end
login