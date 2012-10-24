require 'mongo'
require 'mongo_mapper'
MongoMapper.database="users"

#@f = File.new("text.txt","r")#substituir por save padrão
class User
  include MongoMapper::Document
  key :username, String
  key :email, String
  key :password, String
  key :name, String
# key :save, File, :default =>@f
end

