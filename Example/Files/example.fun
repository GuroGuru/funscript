# PT. 1
# [OK] STRING LITERAL 
# [OK] COMMENTS 
# VISIT TREE
# BUILD OBJECT FROM SCRIPT

# PT. 2
# DECLARATION
# CALL CONTROL -- wait until finished default for now
# FLOW CONTROL STATEMENTS 
# EVENT STATEMENT
# CHARACTERS, PORTRAITS
# FACING? POSITION?
# SHOW AND HIDE

# define grant_key = Event()

# define is_yang = Bool()
# define has_received_welcome = Bool()
# define has_swapped_chars = Bool()

# define arthuros = Character("arthuros", "#FFFFFF" ["arthuros-reference"], "-->")
# define yang = Character("yang", "#FFFFFF" ["yang-reference"], "<--")
# define yun = Character("yun", "#FFFFFF" ["yun-reference"], "<--")

# block main:

#   if is_yang:
#     if has_received_welcome:
#       if has_swapped_chars:
#         call Dialogue5
#       else:
#         call Dialogue4 

#     else:
#       call Dialogue1
#       if has_swapped_chars:
#         call Dialogue3
#       else:
#         call Dialogue2
#   else:
#     if has_received_welcome:
#       call Dialogue7
#     else:
#       call Dialogue6

block Dialogue1:  
  
  # has_received_welcome = True

  # show arthuros_character arthuros_portrait facing_right at left

  # show yang_character yang_portrait facing_left at right

  Arthurus "Bem-vinda, Yang!"      
    
block Dialogue2:  
  
  Arthurus "Para progredir, você deve dominar uma técnica especial."
    
  Yang "Qual técnica?"
    
  Arthurus "Não posso dizer."
    
  Yang "E como é que eu vou descobrir sozinha?"
  
  Arthurus "E quem disse que você está sozinha?"

  Yang "..."

  # hide arthuros_character

  # hide yang_character
  
block Dialogue3: 
  
  Arthurus "Pude perceber que você já domina a técnica de invocar seu irmão Yun."
                  
  Arthurus "Você está pronta para o próximo desafio."

  # event grant_key
  
block Dialogue4:

  Yang "Poxa, sensei, qual é essa técnica?"
  
  Arthurus "Pergunte para outra pessoa hm."
  
block Dialogue5:
  
  Arthurus "Parabéns, Yang! Você descobriu a técnica de invocar seu irmão Yun!"
  
  Arthurus "Agora você deve progredir para a próxima área. Um novo desafio te espera!"

  # event grant_key
  
block Dialogue6:
  
  # has_received_welcome = True

  Arthurus "Bem-vindo, Yun!"
  
  Arthurus "Sua irmã precisará de sua ajuda para o próximo desafio."
  
  Arthurus "Progrida para a próxima área. Boa sorte!"
  
  Yun "Pode deixar, meu chapa! Quer dizer, sensei!"   

  # event grant_key
  
block Dialogue7:
  
  Arthurus "Vejo que sua irmã conseguiu te invocar... Ótimo! Progridam para a próxima área."
  
  Yun "Opa, é nóis! Digo, hai!"

  # event grant_key
