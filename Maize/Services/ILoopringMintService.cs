﻿using Maize;
using Maize.Models;

namespace Maize
{
    public interface ILoopringMintService
    {
        Task<StorageId> GetNextStorageId(string apiKey, int accountId, int sellTokenId, bool verboseLogging);
        Task<CounterFactualNft> ComputeTokenAddress(string apiKey, CounterFactualNftInfo counterFactualNftInfo, bool verboseLogging);
        Task<OffchainFee> GetOffChainFee(string apiKey, int accountId, int requestType, string tokenAddress, bool verboseLogging);
        Task<MintResponseData> MintNft(
            string apiKey,
            string exchange,
            int minterId,
            string minterAddress,
            int toAccountId,
            string toAddress,
            int nftType,
            string tokenAddress,
            string nftId,
            string amount,
            long validUntil,
            int royaltyPercentage,
            int storageId,
            int maxFeeTokenId,
            string maxFeeAmount,
            bool forceToMint,
            CounterFactualNftInfo counterFactualNftInfo,
            string eddsaSignature,
            bool verboseLogging,
            string royaltyAddress);

        Task<CreateCollectionResult> CreateNftCollection(
            string apiKey,
            CreateCollectionRequest createCollectionRequest,
            string apiSig,
            bool verboseLogging);

        Task<UserCollections> FindNftCollection(
             string apiKey,
             int limit,
             int offset,
             string owner,
             string tokenAddress,
             bool verboseLogging);

    }
}
