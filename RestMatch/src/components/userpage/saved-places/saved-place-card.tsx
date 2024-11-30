import { imageUrl } from "@/utils/constants";

interface SavedPlaceCardProps {
  title: string;
}

const SavedPlaceCard: React.FC<SavedPlaceCardProps> = ({title, }) => {
  return (
    <div className="w-[19.125rem] h-[11.5rem] rounded-[2.25rem] shadow-[-6px_7px_7px_2px_rgba(0,0,0,0.5)]">
      <div className="relative flex justify-start">
        <img
          className="w-[19.125rem] h-[11.5rem] rounded-[2.25rem] border-[0.313rem] border-black"
          src={`${imageUrl}/searchpage/restourant-icon.jpg`}
        />
        <div className="h-[3.875rem] w-[19.125rem] grid grid-cols-5 absolute z-10 bottom-0">
          <div className="h-full w-full bg-opacity-50 bg-black bottom-0 col-span-3 flex flex-col justify-center items-center rounded-[1.9rem]">
            <h5 className="text-[1rem]">{title}</h5>
          </div>
          <div className="h-full w-full p-2 flex justify-center">
            <button className="h-full aspect-square flex justify-center items-center rounded-full border-[1px] border-black bg-[#9f784e]">
              <img src={`${imageUrl}/userpage/icon-bookmark.svg`} />
            </button>
          </div>
          <div className="h-full w-full p-2 flex justify-center">
            <button className="h-full aspect-square flex justify-center items-center rounded-full border-[1px] border-black bg-[#9f784e]">
              <img src={`${imageUrl}/userpage/search-white.png`} />
            </button>
          </div>
        </div>
      </div>
    </div>
  );
};

export default SavedPlaceCard;
