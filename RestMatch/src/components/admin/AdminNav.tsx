import Icon from "@/components/common/Icon";
import {AdminActions} from "@/types/enum";

interface AdminNavProps {
  title: string;
  iconName: string;
  action: AdminActions
  active: AdminActions;
  setActiveTab?: (tab: AdminActions) => void;
}

export const AdminNav = (props: AdminNavProps) => {
  const {title, iconName, setActiveTab, action, active} = props;

  const handleClick = (value: AdminActions) => {
    if (setActiveTab) {
      setActiveTab(value);
    }
  }

  return (
    <div
      onClick={() => handleClick(action)}
      className={`${active === action ? 'bg-[#b88b5a]' : 'bg-[#9F784E]'} cursor-pointer border-2 pb-1 border-white w-fit flex-row justify-items-center items-center px-3 pt-3 rounded-t-3xl mb-[-2px] z-10`}
    >
      <Icon name={iconName} size={28}/>
      <div className='font-bold text-xl'>{title}</div>
    </div>
  );
}