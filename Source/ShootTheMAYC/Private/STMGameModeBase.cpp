// Salik Ape Yacht Club. All Rights Reserved. /SBSBSBSBSBSB


#include "STMGameModeBase.h"
#include "Player/STMBaseCharacter.h"
#include "Player/STMPlayerController.h"

    ASTMGameModeBase::ASTMGameModeBase()
        {
        DefaultPawnClass = ASTMBaseCharacter::StaticClass();
            PlayerControllerClass = ASTMPlayerController::StaticClass();
    }
