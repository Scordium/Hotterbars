// Copyright Coffee Stain Studios. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "FGPlayerController.h"
#include "Kismet/BlueprintFunctionLibrary.h"
#include "HotbarUtils.generated.h"

/**
 * 
 */
UCLASS()
class KEYBINDABLEHOTBAR_API UHotbarUtils : public UBlueprintFunctionLibrary
{
	GENERATED_BODY()

	UFUNCTION(BlueprintCallable)
	static void SetHotbarIndex(AFGPlayerController* player, int index) { player->SetHotbarIndex(index); }
	
};
